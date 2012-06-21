
(function (root) {
    var app = root.App;    
    app.Home = app.BaseModel.extend({
        url: "api/items",
        //        defaults: {
        //            id: null,
        //            email: null,
        //            userName: null,
        //            displayName: null,
        //        },
        initialize: function (opt) {
        },
        setCurrentFolder: function (folder) {
            this.fetch();
        }    
    });

    app.HomeView = app.BaseView.extend({
        initialize: function () {
            _.bindAll(this);
            //var self = this;
            this.model.bind("change", this._updateView);
            //this.$el = $(this.el);
        },
        _updateView: function(){

        },
        render: function () {
            var self = this;
            this.$el.hide();
            this.$el.html(mainTpl());
            this.$(".nav a").click(function (e) {
                self.model.setCurrentFolder($(this).data("folder"));
            });
            this.$el.fadeIn('fast');                    
        }
    });

})(window);

