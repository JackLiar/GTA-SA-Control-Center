using ControlCenter.Garages.Constants;
using ControlCenter.Garages.Views;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ControlCenter.Garages
{
    public class Module : IModule
    {
        #region Constructor

        public Module(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Fields & Properites

        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;

        #endregion

        #region Methods

        public void Initialize()
        {
            RegisterViews();
        }

        /// <summary>
        ///     Register views with region using region manager
        /// </summary>
        private void RegisterViews()
        {
            _regionManager.RegisterViewWithRegion(Infrastructure.UI.Constants.RegionNames.GaragesRegion, typeof(Main));
            _regionManager.RegisterViewWithRegion(RegionNames.LosSantosRegion, typeof(LosSantos));
            _regionManager.RegisterViewWithRegion(RegionNames.SanFierroRegion, typeof(SanFierro));
            _regionManager.RegisterViewWithRegion(RegionNames.LasVenturasRegion, typeof(LasVenturas));
            _regionManager.RegisterViewWithRegion(RegionNames.BoneCountyRegion, typeof(BoneCounty));
        }

        #endregion
    }
}