using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace OefeningenLes3_3Door
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        Door _door;

        public MainWindow()
        {
            _door = new Door();

            InitializeComponent();
            lblDoorOpen.Content = _door.Open;
            lblDoorLocked.Content = _door.Locked;

        }

        private void btnOpenDoor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _door.OpenDoor();
                lblDoorOpen.Content = _door.Open;
            }
            catch (OpenDoorWhileOpenException ex)
            {
                lblMessage.Content = ex.Message;
            }
            catch (OpenDoorWhileLockedException ex)
            {
                lblMessage.Content = ex.Message;
            }
        }

        private void btnCloseDoor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _door.CloseDoor();
                lblDoorOpen.Content = _door.Open;
            }
            catch (CloseDoorWhileClosedException ex)
            {
                lblMessage.Content = ex.Message;
            }
        }

        private void btnUnlockDoor_Click(object sender, RoutedEventArgs e)
        {
            _door.UnlockDoor();
            lblDoorLocked.Content = _door.Locked;
        }

        private void btnLockDoor_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _door.LockDoor();
                lblDoorLocked.Content = _door.Locked;

            }
            catch (LockDoorWhileOpenException ex)
            {
                lblMessage.Content = ex.Message;
            }
        }
    }
}
