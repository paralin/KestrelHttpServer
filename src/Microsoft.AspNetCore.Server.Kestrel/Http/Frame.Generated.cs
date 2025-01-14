
using System;
using System.Collections.Generic;

namespace Microsoft.AspNetCore.Server.Kestrel.Http
{
    public partial class Frame
    {
        private static readonly Type IHttpRequestFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestFeature);
        private static readonly Type IHttpResponseFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpResponseFeature);
        private static readonly Type IHttpRequestIdentifierFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature);
        private static readonly Type IServiceProvidersFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature);
        private static readonly Type IHttpRequestLifetimeFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature);
        private static readonly Type IHttpConnectionFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature);
        private static readonly Type IHttpAuthenticationFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature);
        private static readonly Type IQueryFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IQueryFeature);
        private static readonly Type IFormFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IFormFeature);
        private static readonly Type IHttpUpgradeFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature);
        private static readonly Type IResponseCookiesFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature);
        private static readonly Type IItemsFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IItemsFeature);
        private static readonly Type ITlsConnectionFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature);
        private static readonly Type IHttpWebSocketFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpWebSocketFeature);
        private static readonly Type ISessionFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.ISessionFeature);
        private static readonly Type IHttpSendFileFeatureType = typeof(global::Microsoft.AspNetCore.Http.Features.IHttpSendFileFeature);

        private object _currentIHttpRequestFeature;
        private object _currentIHttpResponseFeature;
        private object _currentIHttpRequestIdentifierFeature;
        private object _currentIServiceProvidersFeature;
        private object _currentIHttpRequestLifetimeFeature;
        private object _currentIHttpConnectionFeature;
        private object _currentIHttpAuthenticationFeature;
        private object _currentIQueryFeature;
        private object _currentIFormFeature;
        private object _currentIHttpUpgradeFeature;
        private object _currentIResponseCookiesFeature;
        private object _currentIItemsFeature;
        private object _currentITlsConnectionFeature;
        private object _currentIHttpWebSocketFeature;
        private object _currentISessionFeature;
        private object _currentIHttpSendFileFeature;

        private void FastReset()
        {
            _currentIHttpRequestFeature = this;
            _currentIHttpResponseFeature = this;
            _currentIHttpUpgradeFeature = this;
            _currentIHttpRequestLifetimeFeature = this;
            _currentIHttpConnectionFeature = this;
            
            _currentIHttpRequestIdentifierFeature = null;
            _currentIServiceProvidersFeature = null;
            _currentIHttpAuthenticationFeature = null;
            _currentIQueryFeature = null;
            _currentIFormFeature = null;
            _currentIResponseCookiesFeature = null;
            _currentIItemsFeature = null;
            _currentITlsConnectionFeature = null;
            _currentIHttpWebSocketFeature = null;
            _currentISessionFeature = null;
            _currentIHttpSendFileFeature = null;
        }

        private object FastFeatureGet(Type key)
        {
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestFeature))
            {
                return _currentIHttpRequestFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpResponseFeature))
            {
                return _currentIHttpResponseFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature))
            {
                return _currentIHttpRequestIdentifierFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature))
            {
                return _currentIServiceProvidersFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature))
            {
                return _currentIHttpRequestLifetimeFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature))
            {
                return _currentIHttpConnectionFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature))
            {
                return _currentIHttpAuthenticationFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IQueryFeature))
            {
                return _currentIQueryFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IFormFeature))
            {
                return _currentIFormFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature))
            {
                return _currentIHttpUpgradeFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature))
            {
                return _currentIResponseCookiesFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IItemsFeature))
            {
                return _currentIItemsFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature))
            {
                return _currentITlsConnectionFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpWebSocketFeature))
            {
                return _currentIHttpWebSocketFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.ISessionFeature))
            {
                return _currentISessionFeature;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpSendFileFeature))
            {
                return _currentIHttpSendFileFeature;
            }
            return ExtraFeatureGet(key);
        }

        private void FastFeatureSet(Type key, object feature)
        {
            _featureRevision++;
            
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestFeature))
            {
                _currentIHttpRequestFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpResponseFeature))
            {
                _currentIHttpResponseFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature))
            {
                _currentIHttpRequestIdentifierFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature))
            {
                _currentIServiceProvidersFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature))
            {
                _currentIHttpRequestLifetimeFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature))
            {
                _currentIHttpConnectionFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature))
            {
                _currentIHttpAuthenticationFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IQueryFeature))
            {
                _currentIQueryFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IFormFeature))
            {
                _currentIFormFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature))
            {
                _currentIHttpUpgradeFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature))
            {
                _currentIResponseCookiesFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IItemsFeature))
            {
                _currentIItemsFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature))
            {
                _currentITlsConnectionFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpWebSocketFeature))
            {
                _currentIHttpWebSocketFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.ISessionFeature))
            {
                _currentISessionFeature = feature;
                return;
            }
            if (key == typeof(global::Microsoft.AspNetCore.Http.Features.IHttpSendFileFeature))
            {
                _currentIHttpSendFileFeature = feature;
                return;
            };
            ExtraFeatureSet(key, feature);
        }

        private IEnumerable<KeyValuePair<Type, object>> FastEnumerable()
        {
            if (_currentIHttpRequestFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpRequestFeatureType, _currentIHttpRequestFeature as global::Microsoft.AspNetCore.Http.Features.IHttpRequestFeature);
            }
            if (_currentIHttpResponseFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpResponseFeatureType, _currentIHttpResponseFeature as global::Microsoft.AspNetCore.Http.Features.IHttpResponseFeature);
            }
            if (_currentIHttpRequestIdentifierFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpRequestIdentifierFeatureType, _currentIHttpRequestIdentifierFeature as global::Microsoft.AspNetCore.Http.Features.IHttpRequestIdentifierFeature);
            }
            if (_currentIServiceProvidersFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IServiceProvidersFeatureType, _currentIServiceProvidersFeature as global::Microsoft.AspNetCore.Http.Features.IServiceProvidersFeature);
            }
            if (_currentIHttpRequestLifetimeFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpRequestLifetimeFeatureType, _currentIHttpRequestLifetimeFeature as global::Microsoft.AspNetCore.Http.Features.IHttpRequestLifetimeFeature);
            }
            if (_currentIHttpConnectionFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpConnectionFeatureType, _currentIHttpConnectionFeature as global::Microsoft.AspNetCore.Http.Features.IHttpConnectionFeature);
            }
            if (_currentIHttpAuthenticationFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpAuthenticationFeatureType, _currentIHttpAuthenticationFeature as global::Microsoft.AspNetCore.Http.Features.Authentication.IHttpAuthenticationFeature);
            }
            if (_currentIQueryFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IQueryFeatureType, _currentIQueryFeature as global::Microsoft.AspNetCore.Http.Features.IQueryFeature);
            }
            if (_currentIFormFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IFormFeatureType, _currentIFormFeature as global::Microsoft.AspNetCore.Http.Features.IFormFeature);
            }
            if (_currentIHttpUpgradeFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpUpgradeFeatureType, _currentIHttpUpgradeFeature as global::Microsoft.AspNetCore.Http.Features.IHttpUpgradeFeature);
            }
            if (_currentIResponseCookiesFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IResponseCookiesFeatureType, _currentIResponseCookiesFeature as global::Microsoft.AspNetCore.Http.Features.IResponseCookiesFeature);
            }
            if (_currentIItemsFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IItemsFeatureType, _currentIItemsFeature as global::Microsoft.AspNetCore.Http.Features.IItemsFeature);
            }
            if (_currentITlsConnectionFeature != null)
            {
                yield return new KeyValuePair<Type, object>(ITlsConnectionFeatureType, _currentITlsConnectionFeature as global::Microsoft.AspNetCore.Http.Features.ITlsConnectionFeature);
            }
            if (_currentIHttpWebSocketFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpWebSocketFeatureType, _currentIHttpWebSocketFeature as global::Microsoft.AspNetCore.Http.Features.IHttpWebSocketFeature);
            }
            if (_currentISessionFeature != null)
            {
                yield return new KeyValuePair<Type, object>(ISessionFeatureType, _currentISessionFeature as global::Microsoft.AspNetCore.Http.Features.ISessionFeature);
            }
            if (_currentIHttpSendFileFeature != null)
            {
                yield return new KeyValuePair<Type, object>(IHttpSendFileFeatureType, _currentIHttpSendFileFeature as global::Microsoft.AspNetCore.Http.Features.IHttpSendFileFeature);
            }

            if (MaybeExtra != null)
            {
                foreach(var item in MaybeExtra)
                {
                    yield return item;
                }
            }
        }
    }
}
