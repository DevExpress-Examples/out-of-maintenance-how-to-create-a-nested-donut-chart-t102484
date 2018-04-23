using System.Windows.Controls;
using System.Windows.Media;
using DevExpress.Xpf.Charts;

namespace NestedDonut {
    public partial class MainPage : UserControl {
        public MainPage() {
            InitializeComponent();
        }

        private void ChartControl_CustomDrawSeriesPoint(object sender, CustomDrawSeriesPointEventArgs e) {
            if (e.SeriesPoint.Value <= 10) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0x51, 0x89, 0x03);
            }

            else if ((e.SeriesPoint.Value > 10) & (e.SeriesPoint.Value <= 20)) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0xF9, 0xAA, 0x0F);
            }

            else if (e.SeriesPoint.Value > 20) {
                e.DrawOptions.Color = Color.FromArgb(0xFF, 0xC7, 0x39, 0x0C);
            }
        }
    }
}
