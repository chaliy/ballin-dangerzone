(function (root) {
    var app = root.App;
    var model = new app.Home();
    var view = new app.HomeView({ options: {}, model: model });
    view.render();
    $("#home").append(view.el);

})(window);