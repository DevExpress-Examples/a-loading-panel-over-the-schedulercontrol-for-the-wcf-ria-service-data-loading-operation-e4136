using System;
using System.Windows;
using System.Windows.Controls;

namespace SchedulerCarsSQLServerSLT {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void SchedulerStorage_AppointmentCollectionModified(object sender, EventArgs e) {
            if (ddsAppointments.HasChanges) {
                ddsAppointments.SubmitChanges();
            }
        }

        private void DomainDataSource_LoadedData(object sender, LoadedDataEventArgs e) {
            if (e.HasError) {
                MessageBox.Show("Connection could not be established." + Environment.NewLine + e.Error.Message,
                    "Connection Error", MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }

            if (sender == ddsAppointments && firstLoad) {
                firstLoad = false;
                if (schedulerControl1.Storage.AppointmentStorage.Count > 0) {
                    schedulerControl1.Start = schedulerControl1.Storage.AppointmentStorage[0].Start;
                }
            }
        }

        private void DomainDataSource_SubmittedChanges(object sender, SubmittedChangesEventArgs e) {
            if (e.HasError) {
                MessageBox.Show(e.Error.ToString(), "Submit Changes Error", MessageBoxButton.OK);
                e.MarkErrorAsHandled();
            }
        }

        bool firstLoad = true;
    }
}
