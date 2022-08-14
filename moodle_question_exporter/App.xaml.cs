using moodle_question_exporter.View;
using System.Windows;

namespace moodle_question_exporter {
    public partial class App : Application {

        protected override void OnStartup(StartupEventArgs e) {
            base.OnStartup(e);
            PrincipalView window = new PrincipalView();
            window.Show();
        }
    }
}
