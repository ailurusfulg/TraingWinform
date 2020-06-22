﻿using MetroFramework;
using MetroFramework.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace BookRentalShop20
{
    public partial class BooksForm : MetroForm
    {
        /// <summary>
        /// DB연결 String
        /// </summary>
        string mode = "";
        public BooksForm()
        {
            InitializeComponent();
        }
        private void MemberForm_Load(object sender, EventArgs e)
        {
            UpdateData();   // 데이터그리드 DB 데이터 로딩하기

            UpdateCboDivision();
        }
        private void UpdateCboDivision()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "SELECT Division, Names FROM divtbl";
                SqlDataReader reader = cmd.ExecuteReader();
                Dictionary<string, string> temps = new Dictionary<string, string>();
                while(reader.Read())
                {
                    temps.Add(reader[0].ToString(), reader[1].ToString());
                }
                CboDivision.DataSource = new BindingSource(temps, null);
                CboDivision.DisplayMember = "Value";
                CboDivision.ValueMember = "Key";
                CboDivision.SelectedIndex = -1;
            }
        }
        private void UpdateData()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))   //using이 없으면 conn.Close() 해줘야함
            {
                conn.Open(); //DB 열기
                string strQuery = "  SELECT b.Idx, b.Author, b.Division, d.Names AS 'DivNames', b.Names, b.ReleaseDate, b.ISBN, " +
                                  " REPLACE(CONVERT(VARCHAR, CONVERT(MONEY, b.Price), 1), '.00', '') AS price " +
                                  "    FROM dbo.bookstbl as b " +
                                  "   INNER JOIN dbo.divtbl as d " +
                                  "      ON b.Division = d.Division ";
                //SqlCommand cmd = new SqlCommand(strQuery, conn);  //sql문을 실행할때는 SqlCommand가 꼭 필요하다! update할때는 필요없음
                SqlDataAdapter dataAdapter = new SqlDataAdapter(strQuery, conn);
                DataSet ds = new DataSet();
                dataAdapter.Fill(ds, "bookstbl");

                GrdBooksTbl.DataSource = ds;
                GrdBooksTbl.DataMember = "bookstbl";
            }

            DataGridViewColumn column = GrdBooksTbl.Columns[2];  // Division Column
            column.Visible = false;
        }
        private void GrdDivTbl_CellClick(object sender, System.Windows.Forms.DataGridViewCellEventArgs e)
        {
            if(e.RowIndex > -1)
            {
                //Cells[3]은 inner join으로 결과를 나타내준다.
                DataGridViewRow data = GrdBooksTbl.Rows[e.RowIndex];
                TxtIdx.Text = data.Cells[0].Value.ToString(); // ID
                TxtIdx.ReadOnly = true; //Division이 PK라서 변경하면 안 된다.
                TxtIdx.BackColor = Color.Red;
                TxtAuthor.Text = data.Cells[1].Value.ToString(); // 저자
                CboDivision.SelectedIndex = CboDivision.FindString(data.Cells[2].Value.ToString()); // 책 장르
                TxtNames.Text = data.Cells[4].Value.ToString();  // 책 제목
                DtpReleaseDate.Value = DateTime.Parse(data.Cells[5].Value.ToString());  //발간일
                TxtISBN.Text = data.Cells[6].Value.ToString(); // ISBN
                TxtPrice.Text = data.Cells[7].Value.ToString(); // 가격



                mode = "UPDATE"; // 수정은 UPDATE
            }
        }
        private void BtnNew_Click(object sender, EventArgs e)   //New Button (추가)
        {
            ClearTextControls();
            mode = "INSERT"; // 신규는 INSERT
        }
        private void BtnSave_Click(object sender, EventArgs e)  //Save Button (저장)
        {
            if (string.IsNullOrEmpty(TxtNames.Text) || (string.IsNullOrEmpty(TxtAuthor.Text))
                 || (string.IsNullOrEmpty(TxtISBN.Text)))
            {
                MetroMessageBox.Show(this, "빈값을 지정할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            SaveProcess();
            UpdateData();

            ClearTextControls();
        }
        private void ClearTextControls()
        {
            TxtIdx.Text = TxtAuthor.Text =  TxtNames.Text = TxtISBN.Text = "";
            CboDivision.SelectedIndex = -1;
            TxtIdx.ReadOnly = true; //txtIdx는 자동 증가
            TxtIdx.BackColor = Color.Beige;
            TxtAuthor.Focus();
        }
        private void TxtNames_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
            {
                BtnSave_Click(sender, new EventArgs());
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(TxtIdx.Text) || (string.IsNullOrEmpty(TxtAuthor.Text)))
            {
                MetroMessageBox.Show(this, "빈값은 삭제할 수 없습니다.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return; //메서드를 빠져나가서 더 이상 진행 안 함
            }
            DeleteProcess();
        }
        private void SaveProcess()
        {
            if (String.IsNullOrEmpty(mode))
            {
                MetroMessageBox.Show(this, "신규버튼을 누르고 데이터를 저장하십시오.", "경고",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            //DB저장프로세스
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                string strQuery = "";

                if (mode == "UPDATE")
                {
                    strQuery = "UPDATE dbo.membertbl " +
                                 " SET Names = @Names, " +
                                     " Levels = @Levels, " +
                                     " Addr = @Addr, " +
                                     " Mobile = @Mobile, " +
                                     " Email = @Email " +
                               " WHERE Idx = @Idx ";
                }
                else if (mode == "INSERT")
                {
                    //throw new NotImplementedException(); // 아직 구현 안 됬을 때 에러 발생
                    strQuery = "INSERT INTO dbo.membertbl (Names, Levels, Addr, Mobile, Email) " +
                              " VALUES (@Names, @Levels, @Addr, @Mobile, @Email) ";
                }
                cmd.CommandText = strQuery;

                if (mode == "Update")
                {
                    // TxtIdx 설정 
                    SqlParameter pramIdx = new SqlParameter("@Idx", System.Data.SqlDbType.Int);//Idx 속성 글자타입을 Int, 길이를 Null이 아님으로 지정했음
                    pramIdx.Value = TxtIdx.Text;
                    cmd.Parameters.Add(pramIdx);
                }

                // TxtNames 설정 
                SqlParameter pramNames = new SqlParameter("@Names", System.Data.SqlDbType.NVarChar, 45);//Names 속성 글자타입을 NVarChar, 길이를 45로 지정했음
                pramNames.Value = TxtAuthor.Text;
                cmd.Parameters.Add(pramNames);

                //CboLevels 설정
                SqlParameter parmLevels = new SqlParameter("@Levels", System.Data.SqlDbType.Char, 1);//Levels 속성 글자타입을 Char, 길이를 1로 지정했음
                parmLevels.Value = CboDivision.SelectedItem;
                cmd.Parameters.Add(parmLevels);

                // TxtAddr 설정 
                SqlParameter pramAddr = new SqlParameter("@Addr", System.Data.SqlDbType.VarChar, 100);//Address 속성 글자타입을 VarChar, 길이를 100로 지정했음
                pramAddr.Value = TxtNames.Text;
                cmd.Parameters.Add(pramAddr);

                //// TxtMobile 설정 
                //SqlParameter pramMobile = new SqlParameter("@Mobile", System.Data.SqlDbType.VarChar, 13);//Mobile 속성 글자타입을 VarChar, 길이를 13로 지정했음
                //pramMobile.Value = TxtMobile.Text;
                //cmd.Parameters.Add(pramMobile);

                // TxtEmail 설정 
                SqlParameter pramEmail = new SqlParameter("@Email", System.Data.SqlDbType.VarChar, 50);//Email 속성 글자타입을 VarChar, 길이를 50로 지정했음
                pramEmail.Value = TxtISBN.Text;
                cmd.Parameters.Add(pramEmail);



                cmd.ExecuteNonQuery();  //쿼리문을 실행 시켜주기 위해서, NonQuery를 사용하는것은 값을 돌려받지 않기 위해서
            }
        }
        private void DeleteProcess()
        {
            using (SqlConnection conn = new SqlConnection(Commons.CONNSTRING))
            {
                conn.Open();
                SqlCommand cmd = new SqlCommand();
                cmd.Connection = conn;
                cmd.CommandText = "DELETE FROM dbo.divtbl WHERE Division = @Division";
                SqlParameter parmDivision = new SqlParameter("@Division", SqlDbType.Char, 4);
                parmDivision.Value = TxtIdx.Text;
                cmd.Parameters.Add(parmDivision);

                cmd.ExecuteNonQuery();
                UpdateData();
                ClearTextControls();
            }
        }
        private void TxtIdx_Click(object sender, EventArgs e)
        {

        }
        private void CboLevels_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
        private void TxtEmail_Click(object sender, EventArgs e)
        {

        }
        private void GrdBooksTbl_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
