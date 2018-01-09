using System;
using Prism.Events;
using Prism.Modularity;
using Prism.Regions;

namespace ControlCenter.VehicleAndGameData
{
    public class Module : IModule
    {
        #region Fields & Properites

        private IRegionManager _regionManager;
        private readonly IEventAggregator _eventAggregator;

        #endregion

        #region Constructor

        public Module(RegionManager regionManager, EventAggregator eventAggregator)
        {
            _regionManager = regionManager;
            _eventAggregator = eventAggregator;
        }

        #endregion
        public void Initialize()
        {
            throw new NotImplementedException();
        }
    }
}
