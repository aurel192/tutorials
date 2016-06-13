// http://courseware.codeschool.com/shaping-up-with-angular-js/Slides/level01-05.pdf
// http://campus.codeschool.com/courses/shaping-up-with-angular-js/contents
// http://tutorialzine.com/2013/08/learn-angularjs-5-examples/

// DIRECTIVES – HTML annotations that trigger Javascript behaviors
// MODULES – Where our application components live
// CONTROLLERS – Where we add application behavior
// EXPRESSIONS – How values get displayed within the page

var app = angular.module('store', [ ]);
          AngularJS      APPName   Dependencies
		  
// A DIRECTIVE IS A MARKER ON A HTML TAG THAT TELLS ANGULAR TO RUN OR REFERENCE SOME JAVASCRIPT CODE.
<body ng-controller="StoreController">
//     DIRECTIVE    Name Of Function to Call
		
function StoreController() {
 alert('Welcome, Gregg!');
}

//        RUN THIS MODULE WHEN THE DOCUMENT LOADS
<html ng-app="store">  // NG-APP – ATTACH THE APPLICATION MODULE TO THE PAGE
var app = angular.module('store', [ ]);

EXPRESSIONS: https://docs.angularjs.org/guide/expression
<p>{{"hello" + " you"}} I am  {{4 + 6}} </p>

// CONTROLLERS ARE WHERE WE DEFINE OUR APP’S BEHAVIOR BY DEFINING FUNCTIONS AND VALUES.
(function() {
  var app = angular.module('store', [ ]);
  app.controller('StoreController', function() {
     this.product = gem;
  });
  var gem = {
    name: 'Dodecahedron',
    price: 2.95,
    description: '. . .',
	canPurchase: false
	soldOut: true
  }
})();

// ATTACHING THE CONTROLLER
 <div ng-controller="StoreController as store"> // NG-CONTROLLER – ATTACH A CONTROLLER FUNCTION TO THE PAGE
      DIRECTIVE      CONTROLLER NAME    ALIAS

// DISPLAYING DATA:
{{store.product.name}}

// WILL ONLY SHOW THE ELEMENT IF THE VALUE OF THE EXPRESSION IS TRUE:
<button ng-show="store.product.canPurchase"> Add to Cart </button> // NG-SHOW / NG-HIDE – DISPLAY A SECTION BASED ON AN EXPRESSION
<div ng-show="!store.product.soldOut">
<div ng-hide="store.product.soldOut">

// MULTIPLE ITEMS, ARRAY:
var gems = [
  { name: 'Azurite', price: 2.95 },
  { name: 'Bloodstone', price: 5.95 },
  { name: 'Zircon', price: 3.95 }
];
<h1> {{store.products[0].name}} </h1> 

// REPEAT THIS SECTION FOR EACH PRODUCT:
<div ng-repeat="product in store.products"> // NG-REPEAT – REPEAT A SECTION FOR EACH ITEM IN AN ARRAY
<h1> {{product.name}} </h1> 

// FILTER: FORMAT THIS INTO CURRENCY. PIPE - “SEND THE OUTPUT INTO”
<em class="pull-right"> {{product.price | currency }} </em>
{{ data | filter:options }}
{{'1388123412323' | date:'MM/dd/yyyy @ h:mma'}}
{{'octagon gem' | uppercase}}
{{'My Description' | limitTo:8}}
<li ng-repeat="product in store.products | limitTo:3">
<li ng-repeat="product in store.products | orderBy:'-price'">

var gems = [{
      name: 'Azurite',
      images: [
        full: 'dodecahedron-01-full.jpg',
        thumb: 'dodecahedron-01-thumb.jpg'
      ],
      reviews: [{
        stars: 5,
        body: "I love this gem!",
      }, {
        createdOn: 1397490980837
      }]
    }, {
      name: 'Bloodstone',

// DISPLAYING IMAGE, NG-SRC
<img ng-src="{{product.images[0].full}}"/>


// ASSIGNING A VALUE TO TAB
<section>
  <ul class="nav nav-pills”>
    <li> <a href ng-click="tab = 1">tab1 </a></li> // ASSIGNING A VALUE TO TAB
    <li> <a href ng-click="tab = 2">tab2 </a></li>
</ul>
{{tab}}  // EXPRESSIONS DEFINE A 2-WAY DATA BINDING, THIS MEANS EXPRESSIONS ARE RE-EVALUATED WHEN A PROPERTY CHANGES.
<section>

// WHEN A TAB IS SELECTED IT WILL SHOW THE APPROPRIATE PANEL
<div class="panel" ng-show="tab === 1">   <p>{{product.description}}</p>  </div>

// NG-INIT ALLOWS US TO EVALUATE AN EXPRESSION IN THE CURRENT SCOPE
<section ng-init="tab = 1">

// WE NEED TO SET THE CLASS TO ACTIVE IF CURRENT TAB IS SELECTED 
<section ng-init="tab = 1">
  <ul class="nav nav-pills”>
    <li ng-class="{ active:tab === 1 }">  // NAME OF THE CLASS TO SET. : EXPRESSION TO EVALUATE. IF TRUE, SET CLASS TO “ACTIVE”, OTHERWISE NOTHING
	<a href ng-click="tab = 1">Description</a>
	 
// MOVING OUR TAB INITIALIZER 
app.controller("PanelController", function(){
  this.tab = 1; 
  this.selectTab = function(setTab) {
    this.tab = setTab;
  }
  this.isSelected = function(checkTab){
    return this.tab === checkTab;
  };  
});

<section ng-controller="PanelController as panel">
  <ul class="nav nav-pills">
    <li ng-class="{ active:tab === 1 }"> 
      <a href ng-click="tab = 1">Description</a>
  //  HELYETT;
<section ng-controller="PanelController as panel">
  <ul class="nav nav-pills">
    <li ng-class="{ active: panel.isSelected(1) }"> 
      <a href ng-click="panel.selectTab(1)"">Description</a> 
      
// NG-MODEL BINDS THE FORM ELEMENT VALUE TO THE PROPERTY  
<form name="reviewForm">
  <blockquote>
    {{review.body}}  
  </blockquote> 
  <textarea> ng-model="review.body"></textarea>
  <input type="submit" value="Submit" />
</form>

<input ng-model="review.color" type="radio" value="red" /> Red
<input ng-model="review.color" type="radio" value="blue" /> Blue

// NG-SUBMIT ALLOWS US TO CALL A FUNCTION WHEN THE FORM IS SUBMITTED
<form name="reviewForm" ng-controller="ReviewController as reviewCtrl" ng-submit="reviewCtrl.addReview(product)">

app.controller("ReviewController", function(){
  this.review = {}; // INIT TO EMPTY
  this.addReview = function(product) {
    product.reviews.push(this.review);  // PUSH REVIEW ONTO THIS PRODUCT’S REVIEWS ARRAY
    this.review = {}; // RESETTING THE FORM ON SUBMIT.  CLEAR OUT THE REVIEW, SO THE FORM WILL RESET
  };
});

// VALIDATION
<form name="reviewForm" ng-controller="ReviewController as reviewCtrl" ng-submit="reviewForm.$valid && reviewCtrl.addReview(product)" novalidate >  // TURN OFF DEFAULT HTML VALIDATION
  <select ng-model="reviewCtrl.review.stars" required> // REQUIRED FIELD
    <option value="1">1 star</option> ...
  <div> reviewForm is {{reviewForm.$valid}} </div> // PRINT FORMS VALIDITY

// NG-PRISTINE, NG-DIRTY, NG-INVALID, NG-VALID
<input name="author" ng-model="reviewCtrl.review.author" type="email" required />
<input type="number" name="quantity" min=1 max=10> 
.ng-invalid.ng-dirty {border-color: #FA787E;} // Red border for invalid
.ng-valid.ng-dirty   {border-color: #78FA89;} // Green border for valid

// CREATING A DIRECTIVE WITH AN ASSOCIATED CONTROLLER
<ul class="list-group">
  <li class="list-group-item" ng-repeat="product in store.products">
  <h3>
      {{product.name}}                                // WE’RE GOING TO HAVE MULTIPLE PAGES    --> product-title.html
      <em class="pull-right">${{product.price}}</em>  // THAT WANT TO REUSE THIS HTML SNIPPET. --> product-title.html
  </h3>
  <section ng-controller="PanelController as panel">

  // USING NG-INCLUDE FOR TEMPLATES
      <h3 ng-include="'product-title.html'"> </h3> // NAME OF FILE TO INCLUDE

// CUSTOM DIRECTIVE
      <h3 ng-include="'product-title.html'"></h3> // USING NG-INCLUDE...
      <product-title></product-title>             // Custom Directive

app.directive('productTitle', function(){
  return {
    restrict: 'E',                     // TYPE OF DIRECTIVE: (E FOR ELEMENT), (A FOR ATTRIBUTE) USE ELEMENT DIRECTIVES FOR UI WIDGETS AND ATTRIBUTE DIRECTIVES FOR MIXIN BEHAVIORS... LIKE A TOOLTIP.
    templateUrl: 'product-title.html'  // URL OF A TEMPLATE
  };
});

<h3 product-title></h3>                      // Attribute Directive
<h3> <product-title></product-title> </h3>   // Element Directive

// What if we need a Controller?
<h3> <product-title> </h3> // index.html
<product-panels ng-controller="PanelController as panels"
 . . .
</product-panels>

<section>  // product-panels.html
<ul class="nav nav-pills"> . . . </ul>
<div class="panel" ng-show="panels.isSelected(1)"> . . . </div>
</section>

app.directive('productPanels', function(){ // app.js
  return {
  restrict: 'E',
  templateUrl: 'product-panels.html'
  controller:function(){ ... },
  controllerAs: 'panels'
  };
 //we need to move the functionality inside the directive
 app.controller('PanelController', function(){ ... }
});

// REFACTORING
(function(){ // app.js
  var app = angular.module('store', [ ]);
  app.controller('StoreController', function(){ . . . });
  app.directive('productTitle', function(){ . . . });
  app.directive('productGallery', function(){ . . . });
  app.directive('productPanels', function(){ . . . });
})();


(function(){ // app.js                store depends on store-products
  var app = angular.module('store', ['store-products']);
  app.controller('StoreController', function(){ . . . }
})();

// Different closure means different app variable.
// Define a new module just for Product stuff.
(function(){ // products.js  Module Name
  var app = angular.module('store-products', [ ]);
  app.directive('productTitle', function(){ . . . }); 
  app.directive('productGallery', function(){ . . . });
  app.directive('productPanels', function(){ . . . });
})();

<script src="app.js"></script> // index.html
<script src="products.js"></script> 

// Best to split Modules around functionality: 
// app.js – top-level module attached via ng-app
// products.js – all the functionality for products and only products

// Services give your Controller additional functionality, like; (All built-in Services start with a $ sign)
// Fetching JSON data from a web service with $http
// Logging messages to the JavaScript console with $log
// Filtering an array with $filter

$http({ method: 'GET', url: '/products.json' });      // By using $http as a function with an options object
$http.get('/products.json', { apiKey: 'myApiKey' });  // Or using one of the shortcut methods
// Both return a Promise object with .success() and .error()  If we tell $http to fetch JSON, the result will be automatically decoded into JavaScript objects and arrays

(function(){
  var app = angular.module('store', [ 'store-products' ]);
  // Dependency Injection
  //        StoreController needs the $http Service,        so $http gets injected as an argument
  app.controller('SomeController', [ '$http', '$log', function($http, $log) {
    var store = this; // we need to store what this is.
    store.products = [ ];  // We need to initialize products to an empty array, since the page will render before our data returns from our get request.
    // $http returns a Promise, so success() gets the data
    $http.get('/products.json').success(function(data){
      store.products = data;
    });  
  }]);
})();

// In addition to get() requests, $http can post(), put(), delete().
$http.post('/path/to/resource.json', { param: 'value' });
$http.delete('/path/to/resource.json');
// or any other HTTP method by using a config object
$http({ method: 'OPTIONS', url: '/path/to/resource.json' });
$http({ method: 'PATCH', url: '/path/to/resource.json' });
$http({ method: 'TRACE', url: '/path/to/resource.json' });


