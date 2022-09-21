using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using GoogleMobileAds.Api;

public class adManager : MonoBehaviour
{
    gameManager gm;
    private BannerView bannerView;
    private InterstitialAd interstitial;
    public float count;

    void Start()
    {
      gm = GameObject.Find("gameManager").GetComponent<gameManager>();
      MobileAds.Initialize(initStatus=> { });   
      this.RequestBanner();
      this.RequestInterstitial();
    }

    // Update is called once per frame
    void Update()
    {
        if(gm.count==5)
        {
            this.interstitial.Show();
            gm.count=0;
        }
    }

    void RequestBanner()
    {
#if UNITY_ANDROID
        string adID = "ca-app-pub-8468017109720936/1583134973";
#else
     string adID = "unexpected platform";
#endif

        this.bannerView = new BannerView(adID, AdSize.Banner, AdPosition.Top);
        AdRequest request = new AdRequest.Builder().Build();
        this.bannerView.LoadAd(request);

    }

    void RequestInterstitial()
    {
#if UNITY_ANDROID
        string adID = "ca-app-pub-8468017109720936/7351015715";
#else
     string adID = "unexpected platform";
#endif

        this.interstitial = new InterstitialAd(adID);
        AdRequest request = new AdRequest.Builder().Build();
        this.interstitial.LoadAd(request);
    }
}
