
(function (root) {
    var app = root.App;    
    app.Home = app.BaseModel.extend({
        url: "api/items",
        defaults: {
            folder: "contact.company"            
        },
        initialize: function (opt) {
            _.bindAll(this);
            this.fetch();
            //this.trigger()
        },
        setCurrentFolder: function (folder) {
            this.set("folder", folder);
        },
        getCurrentItems: function () {
            var currentFolder = this.get("folder");            
            return _.filter(this.get("Items"), function (i) {
                return i.Folder == currentFolder;
            });
        }
    });

    app.HomeView = app.BaseView.extend({
        initialize: function () {
            _.bindAll(this);
            this.model.bind("change", this._changed);
        },        
        _changed: function () {
            
            // Update list items
            var listBody = this.$("#itemList");
            listBody.hide();
            var items = this.model.getCurrentItems();
            if (items.length == 0) {
                listBody.html("Bit along here... Folder is empty.");
            } else {
                listBody.empty();
                _.each(this.model.getCurrentItems(), function (i) {
                    if (i.Body) {
                        listBody.append(mailItemTpl(i));
                    } else {
                        listBody.append(contactItemTpl(i));
                    }
                });
            }
            listBody.fadeIn();
            
            // Update current folder
            var currentFolder = this.model.get("folder");
            this.$(".nav a").parent().removeClass("active");
            this.$(".nav a[data-folder='" + currentFolder + "']").parent().addClass("active");            
        },
        _createItem: function () {
            var dialog = $(createContactDialogTpl());            
            dialog.modal({
                backdrop: false
            });
            dialog.find("#message").wysiwyg({
                initialContent: "</br>",
                controls: {
                    createLink: { visible: false },
                    insertImage: { visible: false },
                    insertTable: { visible: false },
                    insertHorizontalRule: { visible: false },
                    html: { visible: false },
                    code: {visible: false }
                }
            });
        },
        render: function () {
            var self = this;
            this.$el.hide();
            this.$el.html(mainTpl());
            this.$(".nav a").click(function (e) {
                self.model.setCurrentFolder($(this).data("folder"));
            });
            this.$el.fadeIn('fast'); 
        },
        events: {            
            "click #createItem": "_createItem",
        },
    });

})(window);

