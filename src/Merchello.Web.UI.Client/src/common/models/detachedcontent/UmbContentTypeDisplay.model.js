/**
 * @ngdoc model
 * @name UmbContentTypeDisplay
 * @function
 *
 * @description
 * Represents a JS version of Merchello's UmbContentTypeDisplay object
 */
var UmbContentTypeDisplay = function() {
    var self = this;
    self.id = '';
    self.key = '';
    self.name = '';
    self.alias = '';
    self.icon = '';
    self.tabs = [];
};

angular.module('merchello.models').constant('UmbContentTypeDisplay', UmbContentTypeDisplay);
