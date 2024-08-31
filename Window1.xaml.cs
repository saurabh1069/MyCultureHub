using System;
using System.IO;
using System.Windows;
using System.Windows.Media.Animation;
using Microsoft.Web.WebView2.Core;

namespace MyCultureHub
{
    public partial class AnimatedPromptWindow : Window
    {
        public AnimatedPromptWindow()
        {
            InitializeComponent();
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
            // Initialize WebView2 environment asynchronously
            await webView2Control.EnsureCoreWebView2Async();

            // HTML content to display in WebView2
            string htmlContent = @"
               <!DOCTYPE html>
<html lang=""en"">

<head>
    <meta charset=""UTF-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">
    <title>Sample Email</title>
    <style>
        /* General styling for the email body */
        body {
            font-family: Arial, sans-serif;
            background-color: #f4f4f4;
            color: #333333;
            margin: 0;
            padding: 0;
        }

        /* Main container for the email content */
        .email-container {
            width: 100%;
            max-width: 600px;
            margin: 0 auto;
            background-color: #ffffff;
            border-radius: 8px;
            overflow: hidden;
            box-shadow: 0 0 10px rgba(0, 0, 0, 0.1);
        }

        /* Header section with logo */
        .email-header {
            background-color: #4CAF50;
            color: white;
            text-align: center;
            padding: 20px;
        }

        /* Main content section */
        .email-content {
            padding: 20px;
        }

        /* Styling for the image */
        .email-content img {
            max-width: 100%;
            height: auto;
            display: block;
            margin: 0 auto 20px;
            border-radius: 8px;
        }

        /* Footer section with contact information */
        .email-footer {
            background-color: #f4f4f4;
            text-align: center;
            color: #888888;
            padding: 10px;
            font-size: 12px;
        }

        /* Responsive styling */
        @media (max-width: 600px) {
            .email-content {
                padding: 10px;
            }
        }
    </style>
</head>

<body>
    <!-- Main container -->
    <div class=""email-container"">

        <!-- Header section -->
        <div class=""email-header"">
            <h1>Welcome to Our Newsletter!</h1>
        </div>

        <!-- Content section -->
        <div class=""email-content"">
            <!-- Sample image -->
            <img src=""https://via.placeholder.com/600x200"" alt=""Newsletter Image"">

            <!-- Main text content -->
            <p>Hello,</p>
            <p>
                We are excited to have you as part of our community! In this newsletter, we aim to keep you updated on the
                latest news, special offers, and events. Stay tuned for more information in the coming weeks!
            </p>
            <p>
                Don't forget to check out our <a href=""https://example.com"">website</a> for more details.
            </p>
            <p>
                Best regards,<br>
                The Team
            </p>
        </div>

        <!-- Footer section -->
        <div class=""email-footer"">
            <p>
                You received this email because you signed up for updates. If you wish to unsubscribe, please click
                <a href=""#"">here</a>.
            </p>
            <p>© 2024 Company Name. All rights reserved.</p>
        </div>
    </div>
</body>

</html>";

            // Load the HTML content directly into WebView2
            webView2Control.NavigateToString(htmlContent);

            // Fade-in animation for the window
            DoubleAnimation fadeIn = new DoubleAnimation(0, 1, TimeSpan.FromSeconds(0.5));
            this.BeginAnimation(Window.OpacityProperty, fadeIn);
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            // Close the window
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Minimize the window
            this.WindowState = WindowState.Minimized;
        }

        private void MaximizeButton_Click(object sender, RoutedEventArgs e)
        {
            // Toggle between normal and maximized state
            if (this.WindowState == WindowState.Maximized)
                this.WindowState = WindowState.Normal;
            else
                this.WindowState = WindowState.Maximized;
        }
    }
}
