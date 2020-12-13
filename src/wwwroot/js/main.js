// var meta = document.createElement('meta');
// meta.setAttribute('property', 'og:image');
// meta.setAttribute('content', 'https://am3pap002files.storage.live.com/y4m6pGkmae0sDT8vB8FsERMargEXW1r7Az2tXISTLqiBYd1BpaAPZcPVNNZuwxqX-rADGjzl1Kypv1lVmzP-oO-ZqAkVLmG3b_8ozbnyr_AGVcrn_IylFjFVL7z1bmsvB_e2mme09C_go4QkTnsg5CtWasUAwRO0KGUxv00URdBN-80d5udrgxcmTHSHzFw9nqP?width=512&height=512&cropmode=none');
// document.getElementsByTagName('head')[0].appendChild(meta);

window.fbAsyncInit = function () {
    FB.init({
        xfbml: true,
        version: 'v9.0'
    });
};

(function (d, s, id) {
    var js, fjs = d.getElementsByTagName(s)[0];
    if (d.getElementById(id)) return;
    js = d.createElement(s); js.id = id;
    js.src = 'https://connect.facebook.net/en_US/sdk/xfbml.customerchat.js';
    fjs.parentNode.insertBefore(js, fjs);
}(document, 'script', 'facebook-jssdk'));