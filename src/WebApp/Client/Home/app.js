(function (root) {
    var app = root.App;

    var model = new app.Home();
    var view = new app.HomeView({ options: {}, model: model });
    view.render();
    $("#home").append(view.el);

    var AppRouter = Backbone.Router.extend({
        routes: {
            "": "home",
            "home": "home",
            "folder/:folder": "folder"
        },
        home: function() {
            model.setCurrentFolder("contact.company"); //Default
        },
        folder: function (folder) {
            model.setCurrentFolder(folder);
        }
    });

    app.Router = new AppRouter;
    
    Backbone.history.start();

})(window);