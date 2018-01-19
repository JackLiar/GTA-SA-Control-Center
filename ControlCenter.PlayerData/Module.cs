using ControlCenter.PlayerData.Constants;
using ControlCenter.PlayerData.Views;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ControlCenter.PlayerData
{
    public class Module : IModule
    {
        #region Fields & Properites

        private readonly IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;

        #endregion

        #region Constructor

        public Module(IRegionManager regionManager, IEventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
        }

        #endregion

        #region Methods

        public void Initialize()
        {
            RegisterViews();
        }

        /// <summary>
        /// Register views with region using region manager
        /// </summary>
        private void RegisterViews()
        {
            _regionManager.RegisterViewWithRegion(Infrastructure.UI.Constants.RegionNames.PlayerDataRegion, typeof(Main));
            _regionManager.RegisterViewWithRegion(RegionNames.CurrentPlayerRegion, typeof(CurrentPlayer));
            _regionManager.RegisterViewWithRegion(RegionNames.PlayerSpeedRegion, typeof(PlayerSpeed));
            _regionManager.RegisterViewWithRegion(RegionNames.WeaponStatusRegion, typeof(WeaponStatus));
            _regionManager.RegisterViewWithRegion(RegionNames.PlayerStatusRegion, typeof(PlayerStatus));
        }

        #endregion
    }
}
