﻿namespace ThemedDemo.Demos.ViewModels
{
    using System.Windows.Media;

    public class DemoViewModel : ThemedDemo.ViewModels.Base.ViewModelBase
    {
        #region private fields
        private Color _SelectedAccentColor;
        #endregion private fields

        #region constructors
        /// <summary>
        /// Class constructor
        /// </summary>
        public DemoViewModel()
        {
            _SelectedAccentColor = Color.FromRgb(180, 0, 0);
        }
        #endregion constructors

        #region properties
        /// <summary>
        /// Gets/sets the currently selected color.
        /// </summary>
        public Color SelectedAccentColor
        {
            get { return _SelectedAccentColor; }
            set
            {
                if (_SelectedAccentColor != value)
                {
                    _SelectedAccentColor = value;
                    RaisePropertyChanged(() => SelectedAccentColor);
                }
            }
        }

        /// <summary>
        /// Gets/sets a description for the currently selected color.
        /// </summary>
        public string Description
        {
            get
            {
                return "The ColorCanvas and ColorPicker controls allow the user to input a color. Not shown in the sample are the ColorPicker's Available, Standard and Recent color lists, which are entirely customizable.";
            }
        }
        #endregion properties
    }
}