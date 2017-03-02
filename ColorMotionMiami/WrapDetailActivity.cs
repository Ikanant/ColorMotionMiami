using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using ColorMotionMiami.Core.Model;
using ColorMotionMiami.Core.Service;

namespace ColorMotionMiami {
    [Activity(Label = "Wrap Detail", MainLauncher = true)]
    public class WrapDetailActivity : Activity {
        private ImageView wrapImageView;
        private TextView wrapNameTextView;
        private TextView shortDescriptionTextView;
        private TextView descriptionTextView;
        private TextView priceTextView;
        private EditText amountEditText;
        private Button cancelButton;
        private Button orderButton;

        private Wrap selectedWrap;
        private WrapDataService dataService;

        protected override void OnCreate(Bundle savedInstanceState) {
            base.OnCreate(savedInstanceState);

            // Create your application here
        }
    }
}