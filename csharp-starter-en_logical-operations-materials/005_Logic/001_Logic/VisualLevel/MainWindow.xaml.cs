using System.Windows;
using System.Windows.Media;

// Receiving information about the level of visualization.

namespace VisualLevel
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void submit_Click(object sender, RoutedEventArgs e)
        {
            tbResult.Text = "Level of visualization:\n";

            // RenderCapability - WPF allows applications to query the current level of rendering.
            // RenderCapability.Tier - Gets a value indicating the rendering of the current thread.
            
            int renderingTier = RenderCapability.Tier >> 16;
            // The value of Int32, high word which corresponds to the rendering of the current thread.
            // 16 and 17 bits.

            // Return       ||  Level of  ||       Notes
            // value        ||  rendering || 
            // --------------------------------------------------------------------------------------------
            // 0x00000000   || 0          || For the application on the device hardware acceleration is not available.
            // 0x00010000   || 1          || partial graphics hardware acceleration is available.
            //              ||            || This corresponds to a DirectX version higher or equal to 7.0 but less than 9.0.
            // 0x00020000   || 2          || Rendering of level 2 means that most of the graphics
            //              ||            || capabilities of WPF should use hardware acceleration,
            //              ||            || if the required system resources are not exhausted.
            //              ||            || This corresponds to a DirectX version that is greater than or equal to 9.0.

            // For more details on what WPF opportunities are provided with hardware acceleration on the above levels, 
            // look at http://msdn.microsoft.com/en-gb/library/ms742196.aspx

            if (renderingTier == 0)
                tbResult.Text += "Video card does not provide hardware acceleration.";

            if (renderingTier == 1)
                tbResult.Text += "Video card provides a partial hardware acceleration.";

            if (renderingTier == 2)
                tbResult.Text += "Video card provides full hardware acceleration.";
        }
    }
}
