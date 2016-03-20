using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Microsoft.Phone.Controls;

using Microsoft.Phone.Shell;
//using Microsoft.Devices; //za vribraciju

namespace Clicker_Counter
{
    public partial class MainPage : PhoneApplicationPage
    {
        //VibrateController Vibration = VibrateController.Default;

        // Constructor
        public MainPage()
        {
            InitializeComponent();
            PhoneApplicationService phoneAppService = PhoneApplicationService.Current;
            phoneAppService.UserIdleDetectionMode = IdleDetectionMode.Disabled;
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {

            int jed = Convert.ToInt32(Jedinice.Text);
            int des = Convert.ToInt32(Desetice.Text);
            int sto = Convert.ToInt32(Stotice.Text);

            jed++;

            if (jed == 10)
            {
                jed = 0;
                des++;

                if (des == 10)
                {
                    des = 0;
                    sto++;

                    if (sto == 10)
                    {
                        sto = 0;
                    }
                }
            }

            Jedinice.Text = Convert.ToString(jed);
            Desetice.Text = Convert.ToString(des);
            Stotice.Text = Convert.ToString(sto);

            //vibration();

        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            MessageBoxResult mb = MessageBox.Show("Confirm Reset.", "Reset" , MessageBoxButton.OKCancel);
            
           if (mb == MessageBoxResult.OK)
            {
                int jed = Convert.ToInt32(Jedinice.Text);
                int des = Convert.ToInt32(Desetice.Text);
                int sto = Convert.ToInt32(Stotice.Text);

                jed = 0;
                des = 0;
                sto = 0;

                Jedinice.Text = Convert.ToString(jed);
                Desetice.Text = Convert.ToString(des);
                Stotice.Text = Convert.ToString(sto);
             }

        }

        private void PhoneApplicationPage_BackKeyPress(object sender, System.ComponentModel.CancelEventArgs e)
        {
            MessageBoxResult mb = MessageBox.Show("Confirm Exit.", "Exit", MessageBoxButton.OKCancel);

            if (mb != MessageBoxResult.OK)
            {
                e.Cancel = true;
            }

        }
        /*
        void vibration()
        {
            Vibration.Start(TimeSpan.FromMilliseconds(50));
        }
        */
    }
}