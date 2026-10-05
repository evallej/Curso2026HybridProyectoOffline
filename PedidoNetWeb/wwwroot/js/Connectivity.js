window.connectivity = {
    dotNetRef=null,
    Initialize: Function(dotNetRef){
    this.dotNetRef = dotNetRef;

    window.addEventListener("online", this.handleOnline);
    window.addEventListener("offline", this.handleOffLine);
    return navigator.onLine;
},
handleOnline: function() {
    if (window.connectivity.dotNetRef) {
        window.connectivity.dotNetRef.invokeMethodAsync("SetOnlineStatus", true);
    }
}
handleOffline: function() {
    if (window.connectivity.dotNetRef) {
        window.connectivity.dotNetRef.invokeMethodAsync("SetOfflineStatus", true);
    }
}

dispose: function() {
    window.removeEventListener("online",this.handleOnline) 
    window.removeEventListener("Offline", this.handleOffLine);
    
}
}