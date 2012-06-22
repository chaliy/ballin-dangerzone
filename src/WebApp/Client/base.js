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


/* ECMA5 */
if (typeof String.prototype.startsWith != 'function') {
    String.prototype.startsWith = function (str) {
        return this.slice(0, str.length) == str;
    };
}
if (typeof String.prototype.endsWith != 'function') {
    String.prototype.endsWith = function (str) {
        return this.slice(-str.length) == str;
    };
}