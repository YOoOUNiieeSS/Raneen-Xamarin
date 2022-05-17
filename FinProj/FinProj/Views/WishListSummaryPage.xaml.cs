using FinProj.DataService;
using Xamarin.Forms.Internals;
using Xamarin.Forms.Xaml;

namespace FinProj.Views
{
    /// <summary>
    /// Page to show the catalog list. 
    /// </summary>
    [Preserve(AllMembers = true)]
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class WishListSummaryPage
    {
        /// <summary>
        /// Initializes a new instance of the <see cref="WishListSummaryPage" /> class.
        /// </summary>
        public WishListSummaryPage()
        {
            this.InitializeComponent();
            this.BindingContext = CatalogDataService.Instance.WishListSummaryViewModel;
        }
    }
}