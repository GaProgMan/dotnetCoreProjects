/******/ (function(modules) { // webpackBootstrap
/******/ 	// The module cache
/******/ 	var installedModules = {};
/******/
/******/ 	// The require function
/******/ 	function __webpack_require__(moduleId) {
/******/
/******/ 		// Check if module is in cache
/******/ 		if(installedModules[moduleId])
/******/ 			return installedModules[moduleId].exports;
/******/
/******/ 		// Create a new module (and put it into the cache)
/******/ 		var module = installedModules[moduleId] = {
/******/ 			exports: {},
/******/ 			id: moduleId,
/******/ 			loaded: false
/******/ 		};
/******/
/******/ 		// Execute the module function
/******/ 		modules[moduleId].call(module.exports, module, module.exports, __webpack_require__);
/******/
/******/ 		// Flag the module as loaded
/******/ 		module.loaded = true;
/******/
/******/ 		// Return the exports of the module
/******/ 		return module.exports;
/******/ 	}
/******/
/******/
/******/ 	// expose the modules object (__webpack_modules__)
/******/ 	__webpack_require__.m = modules;
/******/
/******/ 	// expose the module cache
/******/ 	__webpack_require__.c = installedModules;
/******/
/******/ 	// __webpack_public_path__
/******/ 	__webpack_require__.p = "";
/******/
/******/ 	// Load entry module and return exports
/******/ 	return __webpack_require__(0);
/******/ })
/************************************************************************/
/******/ ([
/* 0 */
/***/ function(module, exports, __webpack_require__) {

	"use strict";
	var greeter_1 = __webpack_require__(1);
	var Main = (function () {
	    function Main(defaultElementId) {
	        this.greeter = new greeter_1.Greeter("Spikey poo!");
	    }
	    Main.prototype.sayHello = function () {
	        this.greeter.sayHello();
	        document.getElementById('greeting').innerHTML = this.greeter.greetingMessage;
	    };
	    Object.defineProperty(Main.prototype, "greetingMessage", {
	        get: function () {
	            return this.greeter.greetingMessage;
	        },
	        enumerable: true,
	        configurable: true
	    });
	    return Main;
	}());
	exports.Main = Main;
	// testing Main class
	var instanceOfMain = new Main('greeter');
	instanceOfMain.sayHello();
	console.log(instanceOfMain.greetingMessage);


/***/ },
/* 1 */
/***/ function(module, exports) {

	"use strict";
	var Greeter = (function () {
	    function Greeter(message) {
	        this.message = message;
	    }
	    Greeter.prototype.sayHello = function () {
	        console.log(this.greetingMessage);
	    };
	    Object.defineProperty(Greeter.prototype, "greetingMessage", {
	        get: function () {
	            return "Hello " + this.message + " from TypeScript";
	        },
	        enumerable: true,
	        configurable: true
	    });
	    return Greeter;
	}());
	exports.Greeter = Greeter;


/***/ }
/******/ ]);
//# sourceMappingURL=bundle.js.map