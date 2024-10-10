using CommunityToolkit.Maui.Core;
namespace CameraViewExternalCameras
{
    public partial class MainPage : ContentPage
    {
        private readonly ICameraProvider _cameraProvider;
        public MainPage(ICameraProvider cameraProvider)
        {
            InitializeComponent();
            _cameraProvider = cameraProvider;
        }

        protected override void OnNavigatedTo(NavigatedToEventArgs args)
        {
            base.OnNavigatedTo(args);

            _cameraProvider.RefreshAvailableCameras(new CancellationToken());

            // should include external cameras plugged in to Android device, but doesn't
            var availableCameras = _cameraProvider.AvailableCameras;
        }
    }

}
