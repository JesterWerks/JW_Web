//@@ sourceURL=VM/HomeIndexVM.js

jQuery(document).ready(function () {
    BindViewModel();

});

var Home = function () {
    var self = this;

};

function BindViewModel() {

    // create instance of model
    var vm = new Home();

    // setup validation for instance
    //vm.errors = ko.validation.group(vm, { deep: true });

    // apply bindings
    ko.applyBindings(vm);

};