namespace DatingApp.Views
{
    //Legacy code.
    //public class BaseView : UserControl
    //{
    //    #region Private Member

    //    /// <summary>
    //    /// The View Model associated with this page.
    //    /// </summary>
    //    private object mViewModel;

    //    #endregion

    //    #region Public Properties

    //    /// <summary>
    //    /// The View Model associated with this page.
    //    /// </summary>
    //    public object ViewModelObject
    //    {
    //        get => mViewModel;
    //        set
    //        {
    //            // If nothing has changed, return
    //            if (mViewModel == value)
    //                return;

    //            // Update the value
    //            mViewModel = value;

    //            // Fire the view model changed method
    //            OnViewModelChanged();

    //            // Set the data context for this page
    //            DataContext = mViewModel;
    //        }
    //    }

    //    #endregion

    //    #region Constructor
    //    /// <summary>
    //    /// Default constructor.
    //    /// </summary>
    //    public BaseView()
    //    {
    //        // Don't bother animating in design time
    //        if (DesignerProperties.GetIsInDesignMode(this))
    //            return;
    //    }
    //    #endregion


    //    /// <summary>
    //    /// Fired when the view model changes
    //    /// </summary>
    //    protected virtual void OnViewModelChanged()
    //    {

    //    }
    //}

    ///// <summary>
    ///// A base page with added ViewModel support
    ///// </summary>
    //public class BaseView<VM> : BaseView
    //    where VM : BaseViewModel, new()
    //{
    //    #region Public Properties

    //    /// <summary>
    //    /// The view model associated with this page
    //    /// </summary>
    //    public VM ViewModel
    //    {
    //        get => (VM)ViewModelObject;
    //        set => ViewModelObject = value;
    //    }

    //    #endregion

    //    #region Constructor

    //    /// <summary>
    //    /// Default constructor
    //    /// </summary>
    //    public BaseView() : base()
    //    {
    //        // If in design time mode...
    //        if (DesignerProperties.GetIsInDesignMode(this))
    //            // Just use a new instance of the VM.
    //            ViewModel = new VM();
    //        //else
    //            // Create a default view model.
    //            //ViewModel = Framework.Service<VM>() ?? new VM();
    //    }

    //    /// <summary>
    //    /// Constructor with specific view model.
    //    /// </summary>
    //    /// <param name="specificViewModel">The specific view model to use, if any</param>
    //    public BaseView(VM specificViewModel = null) : base()
    //    {
    //        // Set specific view model
    //        if (specificViewModel != null)
    //            ViewModel = specificViewModel;
    //        else
    //        {
    //            // If in design time mode...
    //            if (DesignerProperties.GetIsInDesignMode(this))
    //                // Just use a new instance of the VM.
    //                ViewModel = new VM();
    //            //else
    //            //{
    //            //    // Create a default view model
    //            //    ViewModel = Framework.Service<VM>() ?? new VM();
    //            //}
    //        }
    //    }

    //    #endregion
    //}
}
