// File: Theme.cs
using MudBlazor;

namespace Layout
{
    public static class AppTheme
    {
        // Create a new MudTheme and copy default palette
        public static MudTheme MyTheme = new MudTheme()
        {
             PaletteLight = new PaletteLight
            {
                Primary = "#1976d2",
                Secondary = "#9c27b0",
                Background = "#f5f5f5",
                Surface = "#ffffff",
                Success = "#4caf50",
                Info = "#2196f3",
                Warning = "#ff9800",
                Error = "#f44336",
                TextPrimary = "#212121",
                TextSecondary = "#757575"
            }
        };

        // System colors for Statuses
        public static class StatusColors
        {
            public static string Open = "#1976d2";
            public static string InProgress = "#ff9800";
            public static string Closed = "#4caf50";
            public static string Cancelled = "#f44336";
        }

        // Colors for Buttons
        public static class ButtonColors
        {
            public static string Primary = "#1976d2";
            public static string Secondary = "#9c27b0";
            public static string Success = "#4caf50";
            public static string Danger = "#f44336";
            public static string Warning = "#ff9800";
        }

        // Colors for Alerts
        public static class AlertColors
        {
            public static string Info = "#2196f3";
            public static string Success = "#4caf50";
            public static string Warning = "#ff9800";
            public static string Error = "#f44336";
        }

        // Background colors
        public static class Backgrounds
        {
            public static string Page = "#f5f5f5";
            public static string Card = "#ffffff";
            public static string Header = "#1976d2";
        }

        // Text colors
        public static class Text
        {
            public static string Primary = "#212121";
            public static string Secondary = "#757575";
            public static string Inverse = "#ffffff";
            public static string Disabled = "#9e9e9e";
        }
    }
}
