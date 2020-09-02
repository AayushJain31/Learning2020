"use strict";
var __extends = (this && this.__extends) || (function () {
    var extendStatics = function (d, b) {
        extendStatics = Object.setPrototypeOf ||
            ({ __proto__: [] } instanceof Array && function (d, b) { d.__proto__ = b; }) ||
            function (d, b) { for (var p in b) if (Object.prototype.hasOwnProperty.call(b, p)) d[p] = b[p]; };
        return extendStatics(d, b);
    };
    return function (d, b) {
        extendStatics(d, b);
        function __() { this.constructor = d; }
        d.prototype = b === null ? Object.create(b) : (__.prototype = b.prototype, new __());
    };
})();
Object.defineProperty(exports, "__esModule", { value: true });
exports.Patient = void 0;
var Patient = /** @class */ (function () {
    function Patient() {
        this.patientName = "";
        this.patientAddress = "";
        this.patientName = "Typescript";
        this.patientAddress = "JavaScript";
    }
    Patient.prototype.Add = function () {
        console.log("Patient Name : " + this.patientName + " Patient Address : " + this.patientAddress);
    };
    return Patient;
}());
exports.Patient = Patient;
var PatientChild = /** @class */ (function (_super) {
    __extends(PatientChild, _super);
    function PatientChild() {
        var _this = _super !== null && _super.apply(this, arguments) || this;
        _this.i = 0;
        return _this;
    }
    PatientChild.prototype.Add = function () {
    };
    return PatientChild;
}(Patient));
