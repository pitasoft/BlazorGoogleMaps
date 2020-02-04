using System;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps
{
    /// <summary>
    /// google.maps.MapsEventListener interface
    /// An event listener, created by google.maps.event.addListener() and friends.
    /// </summary>
    public class MapEventListener : IDisposable
    {
        private readonly JsObjectRef _jsObjectRef;

        internal MapEventListener(JsObjectRef jsObjectRef)
        {
            _jsObjectRef = jsObjectRef;
        }

        public void Dispose()
        {
            _ = RemoveAsync();
        }

        public async Task RemoveAsync()
        {
            await _jsObjectRef.InvokeAsync<object>("remove");
            await _jsObjectRef.DisposeAsync();
        }
    }
}
