namespace WinFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            
           
            if (list_box.Items.Cast<string>().Contains(txt_input.Text))
            {
                MessageBox.Show("Input Kembar!");
            }
            else
            {
                list_box.Items.Add(txt_input.Text);
                txt_input.Text = "";

            }

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btn_close_Click(object sender, EventArgs e)
        {
            list_box.Items.Clear();
            txt_input.Clear();
            checkbox_aktif.Checked = false;
            check_merah.Checked = true;
            lbl_output.ForeColor = Color.Black;
            lbl_output.Text = "...";
        }
        
        private void checkbox_aktif_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_aktif.Checked == true)
            {
                
                if (check_merah.Checked == true)
                {
                    lbl_output.ForeColor = Color.Red;
                }
                else if (check_biru.Checked == true)
                {
                    lbl_output.ForeColor = Color.Blue;
                }
            }
            else 
            {
                lbl_output.ForeColor= Color.Black;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void list_box_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbl_output.Text = list_box.SelectedItem.ToString();
        }

        private void check_merah_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_aktif.Checked == true)
            {

                if (check_merah.Checked == true)
                {
                    lbl_output.ForeColor = Color.Red;
                }
                else if (check_biru.Checked == true)
                {
                    lbl_output.ForeColor = Color.Blue;
                }
            }
            else
            {
                lbl_output.ForeColor = Color.Black;
            }
        }

        private void check_biru_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_aktif.Checked == true)
            {

                if (check_merah.Checked == true)
                {
                    lbl_output.ForeColor = Color.Red;
                }
                else if (check_biru.Checked == true)
                {
                    lbl_output.ForeColor = Color.Blue;
                }
            }
            else
            {
                lbl_output.ForeColor = Color.Black;
            }
        }
    }
}