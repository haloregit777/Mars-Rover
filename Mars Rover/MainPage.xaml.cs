using Mars_Rover.Rover;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using MUXC = Microsoft.UI.Xaml.Controls;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Mars_Rover
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        //Creates an array of of 5 rover objects
        RoverCommands[] rovers = new RoverCommands[5];

        public MainPage()
        {
            this.InitializeComponent();
        }

        //This is the button to launch the rovers and land them on Mars after choosing the plateau size and a maximum of 5 rovers. It also handles the visibility of various other elements
        private void startBTN_Click(object sender, RoutedEventArgs e)
        {
            if (this.mainGrid.Visibility == Visibility.Visible)
            {
                announce.Text = "Rovers landed successfully in various locations!";
                this.platGrid.Visibility = Visibility.Visible;
                this.mainGrid.Visibility = Visibility.Collapsed;
                int x = Convert.ToInt32(platX.Value);
                int y = Convert.ToInt32(platY.Value);
                int nrR = Convert.ToInt32(nrRovers.Value);                              
                for (int i = 0; i < nrR; i++)
                {
                    rovers[i] = new RoverCommands(x, y);
                }
                if (nrR == 5)
                {
                    r1Out.Text = rovers[0].getInitValues();
                    r2Out.Text = rovers[1].getInitValues();
                    r3Out.Text = rovers[2].getInitValues();
                    r4Out.Text = rovers[3].getInitValues();
                    r5Out.Text = rovers[4].getInitValues();

                    this.r2Out.Visibility = Visibility.Visible;
                    this.r2Title2.Visibility = Visibility.Visible;
                    this.r2Com.Visibility = Visibility.Visible;
                    this.r2Title.Visibility = Visibility.Visible;

                    this.r3Out.Visibility = Visibility.Visible;
                    this.r3Title2.Visibility = Visibility.Visible;
                    this.r3Com.Visibility = Visibility.Visible;
                    this.r3Title.Visibility = Visibility.Visible;

                    this.r4Out.Visibility = Visibility.Visible;
                    this.r4Title2.Visibility = Visibility.Visible;
                    this.r4Com.Visibility = Visibility.Visible;
                    this.r4Title.Visibility = Visibility.Visible;

                    this.r5Out.Visibility = Visibility.Visible;
                    this.r5Title2.Visibility = Visibility.Visible;
                    this.r5Com.Visibility = Visibility.Visible;
                    this.r5Title.Visibility = Visibility.Visible;
                }
                else if (nrR == 4)
                {
                    r1Out.Text = rovers[0].getInitValues();
                    r2Out.Text = rovers[1].getInitValues();
                    r3Out.Text = rovers[2].getInitValues();
                    r4Out.Text = rovers[3].getInitValues();

                    this.r2Out.Visibility = Visibility.Visible;
                    this.r2Title2.Visibility = Visibility.Visible;
                    this.r2Com.Visibility = Visibility.Visible;
                    this.r2Title.Visibility = Visibility.Visible;

                    this.r3Out.Visibility = Visibility.Visible;
                    this.r3Title2.Visibility = Visibility.Visible;
                    this.r3Com.Visibility = Visibility.Visible;
                    this.r3Title.Visibility = Visibility.Visible;

                    this.r4Out.Visibility = Visibility.Visible;
                    this.r4Title2.Visibility = Visibility.Visible;
                    this.r4Com.Visibility = Visibility.Visible;
                    this.r4Title.Visibility = Visibility.Visible;

                    this.r5Out.Visibility = Visibility.Collapsed;
                    this.r5Title2.Visibility = Visibility.Collapsed;
                    this.r5Com.Visibility = Visibility.Collapsed;
                    this.r5Title.Visibility = Visibility.Collapsed;
                }
                else if (nrR == 3)
                {
                    r1Out.Text = rovers[0].getInitValues();
                    r2Out.Text = rovers[1].getInitValues();
                    r3Out.Text = rovers[2].getInitValues();

                    this.r2Out.Visibility = Visibility.Visible;
                    this.r2Title2.Visibility = Visibility.Visible;
                    this.r2Com.Visibility = Visibility.Visible;
                    this.r2Title.Visibility = Visibility.Visible;

                    this.r3Out.Visibility = Visibility.Visible;
                    this.r3Title2.Visibility = Visibility.Visible;
                    this.r3Com.Visibility = Visibility.Visible;
                    this.r3Title.Visibility = Visibility.Visible;

                    this.r4Out.Visibility = Visibility.Collapsed;
                    this.r4Title2.Visibility = Visibility.Collapsed;
                    this.r4Com.Visibility = Visibility.Collapsed;
                    this.r4Title.Visibility = Visibility.Collapsed;

                    this.r5Out.Visibility = Visibility.Collapsed;
                    this.r5Title2.Visibility = Visibility.Collapsed;
                    this.r5Com.Visibility = Visibility.Collapsed;
                    this.r5Title.Visibility = Visibility.Collapsed;
                }
                else if (nrR == 2)
                {
                    r1Out.Text = rovers[0].getInitValues();
                    r2Out.Text = rovers[1].getInitValues();

                    this.r2Out.Visibility = Visibility.Visible;
                    this.r2Title2.Visibility = Visibility.Visible;
                    this.r2Com.Visibility = Visibility.Visible;
                    this.r2Title.Visibility = Visibility.Visible;

                    this.r3Out.Visibility = Visibility.Collapsed;
                    this.r3Title2.Visibility = Visibility.Collapsed;
                    this.r3Com.Visibility = Visibility.Collapsed;
                    this.r3Title.Visibility = Visibility.Collapsed;

                    this.r4Out.Visibility = Visibility.Collapsed;
                    this.r4Title2.Visibility = Visibility.Collapsed;
                    this.r4Com.Visibility = Visibility.Collapsed;
                    this.r4Title.Visibility = Visibility.Collapsed;

                    this.r5Out.Visibility = Visibility.Collapsed;
                    this.r5Title2.Visibility = Visibility.Collapsed;
                    this.r5Com.Visibility = Visibility.Collapsed;
                    this.r5Title.Visibility = Visibility.Collapsed;
                }
                else if (nrR == 1)
                {
                    r1Out.Text = rovers[0].getInitValues();

                    this.r2Out.Visibility = Visibility.Collapsed;
                    this.r2Title2.Visibility = Visibility.Collapsed;
                    this.r2Com.Visibility = Visibility.Collapsed;
                    this.r2Title.Visibility = Visibility.Collapsed;

                    this.r3Out.Visibility = Visibility.Collapsed;
                    this.r3Title2.Visibility = Visibility.Collapsed;
                    this.r3Com.Visibility = Visibility.Collapsed;
                    this.r3Title.Visibility = Visibility.Collapsed;

                    this.r4Out.Visibility = Visibility.Collapsed;
                    this.r4Title2.Visibility = Visibility.Collapsed;
                    this.r4Com.Visibility = Visibility.Collapsed;
                    this.r4Title.Visibility = Visibility.Collapsed;

                    this.r5Out.Visibility = Visibility.Collapsed;
                    this.r5Title2.Visibility = Visibility.Collapsed;
                    this.r5Com.Visibility = Visibility.Collapsed;
                    this.r5Title.Visibility = Visibility.Collapsed;
                }
            } 
        }

        //Returns the user to the main screen to change the plateau size and the amount of rovers
        private void backBTN_Click(object sender, RoutedEventArgs e)
        {
            if (this.platGrid.Visibility == Visibility.Visible)
            {
                this.mainGrid.Visibility = Visibility.Visible;
                this.platGrid.Visibility = Visibility.Collapsed;
                platGrid.Children.Remove((UIElement)this.FindName("newGrid"));
            }
        }

        //This button calls the method that moveds each rover consecutively based on the amount of rovers
        private void r1BTN_Click(object sender, RoutedEventArgs e)
        {
            announce.Text = "Rover commands executed successfully!";
            int nrR = Convert.ToInt32(nrRovers.Value);
            int x = Convert.ToInt32(platX.Value);
            int y = Convert.ToInt32(platY.Value);
            if (nrR == 5)
            {
                r1Out.Text = rovers[0].moveRover(r1Com.Text, r1Out.Text, x, y);
                r2Out.Text = rovers[1].moveRover(r2Com.Text, r2Out.Text, x, y);
                r3Out.Text = rovers[2].moveRover(r3Com.Text, r3Out.Text, x, y);
                r4Out.Text = rovers[3].moveRover(r4Com.Text, r4Out.Text, x, y);
                r5Out.Text = rovers[4].moveRover(r5Com.Text, r5Out.Text, x, y);
            }
            else if (nrR == 4)
            {
                r1Out.Text = rovers[0].moveRover(r1Com.Text, r1Out.Text, x, y);
                r2Out.Text = rovers[1].moveRover(r2Com.Text, r2Out.Text, x, y);
                r3Out.Text = rovers[2].moveRover(r3Com.Text, r3Out.Text, x, y);
                r4Out.Text = rovers[3].moveRover(r4Com.Text, r4Out.Text, x, y);
            }
            else if (nrR == 3)
            {
                r1Out.Text = rovers[0].moveRover(r1Com.Text, r1Out.Text, x, y);
                r2Out.Text = rovers[1].moveRover(r2Com.Text, r2Out.Text, x, y);
                r3Out.Text = rovers[2].moveRover(r3Com.Text, r3Out.Text, x, y);
            }
            else if (nrR == 2)
            {
                r1Out.Text = rovers[0].moveRover(r1Com.Text, r1Out.Text, x, y);
                r2Out.Text = rovers[1].moveRover(r2Com.Text, r2Out.Text, x, y);
            }
            else if (nrR == 1) r1Out.Text = rovers[0].moveRover(r1Com.Text, r1Out.Text, x, y);
        }
    }
}