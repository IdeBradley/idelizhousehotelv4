using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

using Happyhouse;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=391641

namespace Happyhouse
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            this.NavigationCacheMode = NavigationCacheMode.Required;
        }

        /// <summary>
        /// Invoked when this page is about to be displayed in a Frame.
        /// </summary>
        /// <param name="e">Event data that describes how this page was reached.
        /// This parameter is typically used to configure the page.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            // TODO: Prepare page for display here.

            // TODO: If your application contains multiple pages, ensure that you are
            // handling the hardware Back button by registering for the
            // Windows.Phone.UI.Input.HardwareButtons.BackPressed event.
            // If you are using the NavigationHelper provided by some templates,
            // this event is handled for you.
        }
            private void InsertNewRes( Reservation newRes)
        {
            // TODO: Delete or comment the following statement; Mobile Services auto-generates the ID.
            //Reservation.Id = Guid.NewGuid().ToString();

            //// This code inserts a new TodoItem into the database. When the operation completes
            //// and Mobile Services has assigned an Id, the item is added to the CollectionView
            //// TODO: Mark this method as "async" and uncomment the following statement.
            // await reservationTable.InsertAsync(newRes);

            //items.Add(newRes);
        }

        private void RegisterButton_Click(object sender, RoutedEventArgs e)
        {
             // needs to be updated to allow for a " are you sure " ? question
             // need a condition on the terms and conditions check box ( also a place to display the details)
            resultTextBox.Text = " Thank you for requesting a reservation ! ";
             Random rand = new Random();
             int name = rand.Next(1, 999999);
             string resrand = name.ToString();  // roundabout way of generating a unique string key for the Primary Key ;-)
             var newRes = new Reservation { ReservationID = resrand , PropertyID = "POO1",   ClientID= emailTextBox.Text, BookingStatus = " Requested", TimeSegment = "1", Deposit_Received= false };
             InsertNewRes(newRes);
        }
  
    }
}
