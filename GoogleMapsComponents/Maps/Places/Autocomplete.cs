using Microsoft.JSInterop;
using System;
using System.Threading.Tasks;

namespace GoogleMapsComponents.Maps.Places
{
    public class Autocomplete : IDisposable
    {
        private readonly JsObjectRef _jsObjectRef;

        public async static Task<Autocomplete> CreateAsync(IJSRuntime jsRuntime, MarkerOptions opts = null)
        {
            var jsObjectRef = await JsObjectRef.CreateAsync(jsRuntime, "google.maps.Marker", opts);
            var obj = new Autocomplete(jsObjectRef);

            return obj;
        }

        private Autocomplete(JsObjectRef jsObjectRef)
        {
            _jsObjectRef = jsObjectRef;
        }

        public void Dispose()
        {
            _jsObjectRef?.Dispose();
        }
    }
}
