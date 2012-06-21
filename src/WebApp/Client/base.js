(function (root) {
    var app = root.App = root.App || {};
    
    app.BaseView = Backbone.View.extend({
        loading: function () {
            $(this.el).css({ opacity: 0.5 });
        },
        finishedLoading: function () {
            $(this.el).css({ opacity: 1 });
        }
    });

    app.BaseModel = Backbone.Model.extend({
    });


})(window);

