function showSignInContent() {
    var target = document.getElementById("LandingMenu");
    var showTarget = document.getElementById("signInModule");
    target.style.display = "none";
    showTarget.style.display = "block";
}

function showLandingMenu() {
    var showTarget = document.getElementById("LandingMenu");
    var target = document.getElementById("signInModule");
    var createModule = document.getElementById("createAccountModule");
    var createTitle = document.getElementById("createAccountTitle");
    var createArtistHeading = document.getElementById("createArtistTitle");
    var createArtist = document.getElementById("createArtistModule");
    showTarget.style.display = "block";
    target.style.display = "none";
    createModule.style.display = "none";
    createTitle.style.display = "none";
    createArtist.style.display = "none";
    createArtistHeading.style.display = "none";
    
}

function showCustomerAccountModule() {
    var target = document.getElementById("LandingMenu");
    var showTargetHeading = document.getElementById("createAccountTitle");
    var showTarget = document.getElementById("createAccountModule");
    target.style.display = "none";
    showTarget.style.display = "flex";
    showTargetHeading.style.display = "flex";
}

function showArtistAccountModule() {
    var target = document.getElementById("LandingMenu");
    var showTargetHeading = document.getElementById("createArtistTitle");
    var showTarget = document.getElementById("createArtistModule");
    target.style.display = "none";
    showTarget.style.display = "flex";
    showTargetHeading.style.display = "flex";
}

