// wwwroot/browserDetector.js
window.browserDetector = {
    getBrowserName: function () {
        const userAgent = navigator.userAgent;
        if (userAgent.includes("Chrome")) return "Chrome";
        if (userAgent.includes("Firefox")) return "Firefox";
        if (userAgent.includes("Safari") && !userAgent.includes("Chrome")) return "Safari";
        if (userAgent.includes("MSIE") || userAgent.includes("Trident")) return "Internet Explorer";
        return "Unknown";
    },
    getBrowserVersion: function () {
        const userAgent = navigator.userAgent;
        const match = /(Chrome|Firefox|Safari|MSIE|Trident)\/?\s*(\d+)/i.exec(userAgent);
        return match ? match[2] : "Unknown";
    },
    getPlatform: function () {
        return navigator?.userAgentData?.platform || navigator?.platform || "unknown";
    },
    isTouchDevice: function () {
        return "ontouchstart" in window || navigator.maxTouchPoints > 0;
    },
    isMobile: function () {
        return /android|iphone|ipad|ipod|blackberry|iemobile|opera mini/i.test(navigator.userAgent.toLowerCase());
    },
    hasWebGL: function () {
        try {
            const canvas = document.createElement("canvas");
            return !!window.WebGLRenderingContext && (canvas.getContext("webgl") || canvas.getContext("experimental-webgl"));
        } catch (e) {
            return false;
        }
    },
    hasServiceWorker: function () {
        return "serviceWorker" in navigator;
    },
    supportsLocalStorage: function () {
        try {
            const test = "__storage_test__";
            localStorage.setItem(test, test);
            localStorage.removeItem(test);
            return true;
        } catch (e) {
            return false;
        }
    },
    supportsSessionStorage: function () {
        try {
            const test = "__storage_test__";
            sessionStorage.setItem(test, test);
            sessionStorage.removeItem(test);
            return true;
        } catch (e) {
            return false;
        }
    },
    supportsCanvas: function () {
        return !!document.createElement("canvas").getContext;
    },
    supportsGeoLocation: function () {
        return "geolocation" in navigator;
    }
};
