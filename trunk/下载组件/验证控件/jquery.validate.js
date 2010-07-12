/*
* jquery.okValidate 
*
* Copyright (c) 2010 Asher Van Brunt | http://www.okbreathe.com
* Dual licensed under MIT and GPL.
* http://www.opensource.org/licenses/mit-license.php
* Date: 05/11/10
*
* @projectDescription Simple Validation for forms
* @author Asher Van Brunt
* @mailto asher@okbreathe.com
* @version 0.6
*
* @id jQuery.fn.okValidate
* @param {Object} Hash of settings, none are required.
* @return {jQuery} Returns the same jQuery object
*
* Notes:
*	- The plugin has only been tested with jQuery v 1.3.1, v 1.4.2 
*/

(function($) {
    // Check if an object has any properties
    function isEmpty(ob) {
        for (var i in ob) { if (ob.hasOwnProperty(i)) { return false; } }
        return true;
    }

    $.fn.okValidate = function(opts) {

        opts = $.extend({
            inlineErrors: true,                           // If true errors will be appended after the offending inputs, if false will appear at the top of the form
            liveValidation: true,                         // If true errors will appear after the field loses focus, if false only after submit is clicked
            liveEvent: 'blur',                            // Should be 'blur' or 'keyup'
            errorClass: "error",                          // The class that will be added to inputs with errors (note: only for inlineErrors)
            errorContainerClass: "error-messages",        // When not using inline errors, errors will be wrapped in a label with this class
            showErrorFunction: null,                      // Custom function for showing the errorlist
            hideErrorFunction: null,                      // Custom function for hiding the errorlist
            onSubmit: null,                               // Alternate function to call instead of default action
            fieldName: function(input) {                   // The result of this function will be substituted into the error message for #{field}
                return input.attr('name').replace(/[\[\]_-]+/g, ' ');
            }
        }, opts);

        // Deep extending the object causes regexps to turn into objects
        var validators = $.fn.okValidate.validators,
        messages = $.fn.okValidate.messages;

        // We don't necessarily want to append directly to the input because they
        // are commonly wrapped in labels
        function getErrorElement(input) {
            return input.parent()[0].tagName == "LABEL" ? input.parent() : input;
        }

        function generateMessage(msg, matches) {
            if (typeof (msg) == "function") {
                msg = msg.apply(this, [opts.fieldName(this)].concat(matches));
            } else {
                msg = msg.replace("#{field}", opts.fieldName(this))
                for (var i = 0; i < matches.length; i++) {
                    msg = msg.replace("#{" + (i + 1) + "}", matches[i]);
                }
            }
            return msg;
        }

        // Constructs the error markup
        function generateErrorList(errors) {
            var output = '';
            $.each(errors, function(id, el) {
                $.each(el.data('messages'), function(k, msg) {
                    output += "<li>" + msg + "</li>";
                });
            });
            return "<div class='" + opts.errorContainerClass + "'><ul>" + output + '</ul></div>';
        }

        // Error list is prepended before the form itself
        function displayErrorList() {
            removeErrorList.call(this);

            if (opts.showErrorFunction) {
                opts.showErrorFunction.call(this);
            } else {
                this.find('.error').removeClass('error');
                $.each(this.data('errors'), function() {
                    $(this).addClass(opts.errorClass);
                });
                this.prepend(generateErrorList(this.data('errors'))).find("." + opts.errorContainerClass).hide().slideDown();
            }
        }

        function removeErrorList() {
            if (opts.hideErrorFunction) {
                opts.hideErrorFunction.call(this);
            } else {
                this.find('.error').removeClass('error');
                $("." + opts.errorContainerClass, this).remove();
            }
        }

        // Errors appended to individual fields
        function appendErrorsTo(input) {
            var label = $("<label/>"),
          msg = input.data('messages').join(", ");
            if (opts.showErrorFunction) {
                opts.showErrorFunction.call(this);
            } else {
                if (input.data('label')) {
                    input.data('label').html(msg);
                } else {
                    input.addClass(opts.errorClass);
                    label.addClass(opts.errorClass).text(msg).insertAfter(getErrorElement(input));
                    input.data('label', label);
                }
            }
        }

        function removeErrorsFrom(input) {
            if (opts.hideErrorFunction) {
                opts.hideErrorFunction.call(this);
            } else {
                if (input.data('label')) {
                    input.data('label').remove();
                    input.data('label', null).removeClass(opts.errorClass);
                }
            }
        }

        function maybeDisplayErrors(form, event) {
            if (opts.inlineErrors && this && this.data('messages').length <= 0) {
                removeErrorsFrom(this);
                return true;
            } else if (isEmpty(form.data('errors'))) {
                removeErrorList.call(form);
                return true;
            }

            opts.inlineErrors ?
        $.each(form.data('errors'), function(k, v) { appendErrorsTo($(v)); }) :
        displayErrorList.call(form);

            if (event) {
                event.stopPropagation();
                event.preventDefault();
            }
            return false;
        }

        /*
        * This is the where the meat of the processing occurs. If the input has a
        * class matching an existing validator name we will attempt to validate
        * against it.  If it isn't valid add a message to the messages array.
        * Finally, if the input contains any error messages append it to form's
        * error field list otherwise remove it from the list
        */
        function validateInput(input, form) {
            var validatorName, validator, matches,
          compiled = compileValidators(),
          i = compiled.length,
          assign_or_get_id = function(i) { if (!i.attr('id')) { i.attr('id', "input_" + parseInt(new Date().getTime() + Math.random(), 10)); } };

            input.data('messages', []);

            while (i--) {
                matches = input[0].className.match(compiled[i][0]);
                if (matches) {
                    validatorName = compiled[i][2];
                    validator = compiled[i][1];
                    if (!(typeof (validator) == 'function' ? validator.apply(input, matches.slice(1)) : validator.test(input.val()))) {
                        if (validatorName == 'required' || (input.val() != "")) { // Prevent empty inputs from triggering validation errors
                            assign_or_get_id(input);
                            input.data('messages').push(generateMessage.call(input, messages[validatorName], matches.slice(1)));
                            form.data('errors')[input.attr('id')] = input;
                        }
                    }
                }
            }

            if (input.data('messages').length <= 0) {
                delete form.data('errors')[input.attr('id')];
            }
        }

        // Returns [RegExp,Validator,Validator Name]
        function compileValidators() {
            var arr = [];
            for (var key in $.fn.okValidate.validators) {
                arr.push([new RegExp(key), $.fn.okValidate.validators[key], key]);
            }
            return arr;
        }

        return this.each(function() {
            var form = $(this),
          inputs = $("input[type='checkbox'], input[type='password'], input[type='radio'].required, input[type='text'], select, textarea", form),
          onEvent = function(e) {
              // Only test the last item of a checkbox or radio group
              var input = /(checkbox|radio)/.test(this.type) ? $("input[type='" + RegExp.$1 + "'][name='" + this.name + "']:last", form) : $(this);
              validateInput(input, form);
              maybeDisplayErrors.call(input, form, e);
          }

            form.data('errors', {});

            if (opts.liveValidation) {
                inputs[opts.liveEvent](function() { onEvent.call(this); });
            }

            form.submit(function(e) {
                inputs.each(function() { onEvent.call(this, e); });
                if (opts.onSubmit) {
                    opts.onSubmit.call(form, e);
                }
            });
        });
    };

    $.fn.okValidate.validators = {
        required: function() {
            return (/(checkbox|radio)/.test(this[0].type) ? $("input[type='" + RegExp.$1 + "'][name='" + this[0].name + "']").is(':checked') : (this.val() != '' || this.val() != this.attr('title')));
        },
        email: /^\w+([-+.]\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*$/,
        english: /^[A-Za-z]+$/,
        chinese: /^[\u0391-\uFFE5]+$/,
        url: /^http:\/\/[A-Za-z0-9]+\.[A-Za-z0-9]+[\/=\?%\-&_~`@[\]\':+!]*([^<>\"\"])*$/,
        ip: /^(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5]).(0|[1-9]\d?|[0-1]\d{2}|2[0-4]\d|25[0-5])$/,
        zip: /^[1-9]\d{5}$/,
        qq: /^[1-9]\d{4,10}$/,
        alpha: /^[0-9a-zA-Z\_]+$/,
        phone: /^((\(\d{2,3}\))|(\d{3}\-))?(\(0\d{2,3}\)|0\d{2,3}-)?[1-9]\d{6,7}(\-\d{1,4})?$/,
        numeric: function() { return !isNaN(this.val()); },
        "length\\[(\\d+),?(\\d+)?\\]": function(b1, b2) { // If we only have one bound, assume its the upper bound
            var len = this.val().length;
            return b1 && b2 ? (len >= b1 && len <= b2) : (len <= b1);
        }
    };

    $.fn.okValidate.messages = {
        required: "#{field}不能为空",
        email: "不合法的邮箱地址",
        english: "#{field}必须为英文",
        chinese: "#{field}必须为中文",
        url: "不合法的URL地址",
        ip: "不合法的IP地址",
        zip: "#{field}格式必须为xxxxxx",
        qq: "QQ号必须为10为以内数字",
        alpha: "",
        phone: "电话号码格式不正确",
        numeric: "#{field}必须为数字",
        usd: "#{field} must be a US Dollar amount.",
        "length\\[(\\d+),?(\\d+)?\\]": function(name, b1, b2) { // If we only have one bound, assume its the upper bound
            return name + (b1 && b2 ? " 长度必须在 " + b1 + " 和 " + b2 + " 个字符之间" : " 长度必须大于 " + b1 + " 个字符");
        }
    };
})(jQuery);
