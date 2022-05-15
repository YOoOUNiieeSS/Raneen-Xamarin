using project.DataService;
using Syncfusion.ListView.XForms;
using Xamarin.Forms;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace project.Views
{
    /// <summary>
    /// The Category Tile page.
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SubCategoryTilePage
    {
        public string title;
        /// <summary>
        /// Initializes a new instance of the <see cref="CategoryTilePage" /> class.
        /// </summary>
        public SubCategoryTilePage(string title)
        {
            this.InitializeComponent();
            this.title = title;
            this.BindingContext = CategoryDataService.Instance.CategoryPageViewModel;
        }

        protected override void OnSizeAllocated(double width, double height)
        {
            base.OnSizeAllocated(width, height);

            if (width < height)
            {
                if (this.CategoryTile.LayoutManager is GridLayout)
                {
                    (this.CategoryTile.LayoutManager as GridLayout).SpanCount = 2;
                }
            }
            else
            {
                if (this.CategoryTile.LayoutManager is GridLayout)
                {
                    (this.CategoryTile.LayoutManager as GridLayout).SpanCount = 3;
                }
            }
        }
    }
}