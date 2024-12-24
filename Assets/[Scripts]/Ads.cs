using System.Collections;
using System.Collections.Generic;
using UnityEngine;
//using UnityEngine.Advertisements;

public class Ads : MonoBehaviour//,IUnityAdsInitializationListener, IUnityAdsLoadListener, IUnityAdsShowListener
{
    // [SerializeField] string _androidGameId = "000";
    // [SerializeField] string _iOsGameId = "000";
    // [SerializeField] bool _testMode = true; //always false
    // [SerializeField] bool _enablePerPlacementMode = true;
    // [SerializeField] private string _gameId;
    // [SerializeField] private string _androidAdUnitId = "Android_Interstitial";
    // [SerializeField] private string rewardedAndoridAd = "Android_Rewarded";
    // [SerializeField] private string _iOsAdUnitId = "iOS_Interstitial";
    // [SerializeField] private string rewardediOSAd = "iOS_Rewarded"; 
    // [SerializeField] BannerPosition _bannerPosition = BannerPosition.TOP_CENTER;
    // [SerializeField] string _androidAdUnitIdBanner = "Android_Banner";
    // [SerializeField] string _iOsAdUnitIdBanner = "iOS_Banner";
    // string _adUnitId;
    // string _adUnitIdBanner;


    void Awake()
    {
        // _adUnitId = (Application.platform == RuntimePlatform.IPhonePlayer)
        //     ? _iOsAdUnitId
        //     : _androidAdUnitId;

        // _adUnitIdBanner = (Application.platform == RuntimePlatform.IPhonePlayer)
        //     ? _iOsAdUnitIdBanner
        //     : _androidAdUnitIdBanner;

        // InitializeAds();
    }

    void Start()
    {
        // Advertisement.Banner.SetPosition(_bannerPosition);
        // LoadBanner();
        // ShowBannerAd();        
    }

    void Update()
    {
        
    }

    // public void InitializeAds()
    // {
    //     _gameId = (Application.platform == RuntimePlatform.IPhonePlayer)
    //         ? _iOsGameId
    //         : _androidGameId;
    //     Advertisement.Initialize(_gameId, _testMode, _enablePerPlacementMode, this);
    // }

    // public void OnInitializationComplete()
    // {
    //     Debug.Log("Unity Ads initialization complete.");
    //     LoadAd();
    // }

    // public void OnInitializationFailed(UnityAdsInitializationError error, string message)
    // {
    //     Debug.Log($"Unity Ads Initialization Failed: {error.ToString()} - {message}");
    // }

    // // Load content to the Ad Unit:
    // public void LoadAd()
    // {
    //     // IMPORTANT! Only load content AFTER initialization (in this example, initialization is handled in a different script).
    //     Debug.Log("Loading Ad: " + _adUnitId);
    //     Advertisement.Load(_adUnitId, this);
    // }

    // public void ShowAd()
    // {
    //     // Note that if the ad content wasn't previously loaded, this method will fail
    //     Debug.Log("Showing Ad: " + _adUnitId);
    //     Advertisement.Show(_adUnitId, this);
    // }

    // // Implement Load Listener and Show Listener interface methods:  
    // public void OnUnityAdsAdLoaded(string adUnitId)
    // {
    //     // Optionally execute code if the Ad Unit successfully loads content.
    // }

    // public void OnUnityAdsFailedToLoad(string adUnitId, UnityAdsLoadError error, string message)
    // {
    //     Debug.Log($"Error loading Ad Unit: {adUnitId} - {error.ToString()} - {message}");
    //     // Optionally execite code if the Ad Unit fails to load, such as attempting to try again.
    // }

    // public void OnUnityAdsShowFailure(string adUnitId, UnityAdsShowError error, string message)
    // {
    //     Debug.Log($"Error showing Ad Unit {adUnitId}: {error.ToString()} - {message}");
    //     // Optionally execite code if the Ad Unit fails to show, such as loading another ad.
    // }

    // public void OnUnityAdsShowStart(string adUnitId) { }
    // public void OnUnityAdsShowClick(string adUnitId) { }
    // public void OnUnityAdsShowComplete(string adUnitId, UnityAdsShowCompletionState showCompletionState) { }

    // public void LoadBanner()
    // {
    //     // Load the Ad Unit with banner content:
    //     Advertisement.Banner.Load(_adUnitIdBanner);
    // }

    // // Implement code to execute when the load errorCallback event triggers:
    // void OnBannerError(string message)
    // {
    //     Debug.Log($"Banner Error: {message}");
    //     // Optionally execute additional code, such as attempting to load another ad.
    // }

    // // Implement a method to call when the Show Banner button is clicked:
    // void ShowBannerAd()
    // {
    //     // Set up options to notify the SDK of show events:
    //     BannerOptions options = new BannerOptions
    //     {
    //         clickCallback = OnBannerClicked,
    //         hideCallback = OnBannerHidden,
    //         showCallback = OnBannerShown
    //     };

    //     // Show the loaded Banner Ad Unit:
    //     Advertisement.Banner.Show(_adUnitIdBanner, options);
    // }

    // // Implement a method to call when the Hide Banner button is clicked:
    // void HideBannerAd()
    // {
    //     // Hide the banner:
    //     Advertisement.Banner.Hide();
    // }

    // void OnBannerClicked() { }
    // void OnBannerShown() { }
    // void OnBannerHidden() { }
}

