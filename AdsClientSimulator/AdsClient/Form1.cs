using TwinCAT.Ads;
using System.IO;


namespace AdsClient
{
    public partial class Form1 : Form
    {
        private TcAdsClient ads = new TcAdsClient();
        private int ch_gp_ch_checks_disable_sdp_handle;
        private int ch_gp_ct_no_production_cnt_handle;
        private int ch_motor_stack_level_error_counter_cnt_handle;
        private int ch_motor_slow_phase_ifl_handle;
        public Form1()
        {
            InitializeComponent();
            ads.Connect(851);
            if (ads.IsConnected)
            {
                MessageBox.Show("Connection OK");
            }
            else
            {
                MessageBox.Show("Connection NOK");
            }
            ch_gp_ch_checks_disable_sdp_handle = 
                ads.CreateVariableHandle("MAIN.ch_gp_ch_checks_disable_sdp");
            ch_gp_ct_no_production_cnt_handle = 
                ads.CreateVariableHandle("MAIN.ch_gp_ct_no_production_cnt");
            ch_motor_stack_level_error_counter_cnt_handle =
                ads.CreateVariableHandle("MAIN.ch_motor_stack_level_error_counter_cnt");
            ch_motor_slow_phase_ifl_handle =
                ads.CreateVariableHandle("MAIN.ch_motor_slow_phase_ifl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ads.WriteAny(ch_gp_ch_checks_disable_sdp_handle,
                ch_gp_ch_checks_disable_sdp.Text == "1");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ads.WriteAny(ch_gp_ct_no_production_cnt_handle,
                Convert.ToInt16(ch_gp_ct_no_production_cnt.Text));
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ads.WriteAny(ch_motor_stack_level_error_counter_cnt_handle,
                Convert.ToInt16(ch_motor_stack_level_error_counter_cnt.Text));
        }

        private void button4_Click(object sender, EventArgs e)
        {
            ads.WriteAny(ch_motor_slow_phase_ifl_handle,
                Convert.ToInt16(ch_motor_slow_phase_ifl.Text));
        }
    }
}