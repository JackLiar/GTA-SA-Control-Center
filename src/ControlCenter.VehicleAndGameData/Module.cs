using ControlCenter.VehicleAndGameData.Views;
using ControlCenter.VehicleAndGameData.Constants;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ControlCenter.VehicleAndGameData
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
            _regionManager.RegisterViewWithRegion(Infrastructure.UI.Constants.RegionNames.VehicleAndGameDataRegion, typeof(Main));
            _regionManager.RegisterViewWithRegion(RegionNames.CarSpawnRegion, typeof(CarSpwan));
            _regionManager.RegisterViewWithRegion(RegionNames.CurretCarRegion, typeof(CurrentCar));
            _regionManager.RegisterViewWithRegion(RegionNames.CarStatusRegion, typeof(CarStatus));
            _regionManager.RegisterViewWithRegion(RegionNames.GameDataRegion, typeof(GameData));
            _regionManager.RegisterViewWithRegion(RegionNames.GirlFriendRegion, typeof(GirlFriend));
        }

        #endregion
    }
}
