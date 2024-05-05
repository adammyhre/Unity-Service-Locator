using UnityEngine;

namespace UnityServiceLocator {
    [AddComponentMenu("ServiceLocator/ServiceLocator Scene")]
    public class ServiceLocatorScene : Bootstrapper {
        protected override void Bootstrap() {
            Container.ConfigureForScene();            
        }
    }
}