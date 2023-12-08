        private void bt_click_Click(object sender, EventArgs e)
        {
            try
            {
                MySqlConnection connection = new MySqlConnection("Server=localhost;Database=integrateexam1;Uid=root;Pwd=kysA247365!@;");
                connection.Open();//sql 서버 연결
                int login_status = 0;//로그인 상태 변수 
                string loginid = textBox1.Text;//텍스트박스1에 대입
                string loginpwd = textBox2.Text;//텍스트박스2에 대입
                string selectQuery = "SELECT * FROM account_info WHERE id = '" + loginid + "'";
                MySqlCommand Selectcommand = new MySqlCommand(selectQuery, connection);
                MySqlDataReader userAccount = Selectcommand.ExecuteReader();
                while (userAccount.Read())
                {
                    if (loginid == (string)userAccount["id"] && loginpwd == (string)userAccount["pwd"])
                    {
                        login_status = 1;//로그인 성공
                    }

                }
                connection.Clone();
                if (login_status == 1)
                {
                    MessageBox.Show("로그인 성공");
                    userId = loginid; // 올바른 사용자 아이디 할당
                    this.Hide(); // 현재 폼 숨기기
                    Form3 form3 = new Form3(userId);
                    form3.Show();
                }
                else
                {
                    MessageBox.Show("회원 정보를 다시 확인해 주세요.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void CLOSEBT_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
