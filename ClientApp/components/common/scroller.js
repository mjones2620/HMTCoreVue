import $ from 'jquery'
import easing from 'jquery-easing'

$(function () {
    $("#homeLink").addClass("showActive").addClass("highlight");

    $(document).on('scroll', function () {

        if ($(window).scrollTop() > 1150) {
            $('.scroll-top-wrapper').addClass('show');
        } else {
            $('.scroll-top-wrapper').removeClass('show');
        }
    });
});

/**
* This part handles the highlighting functionality.
* We use the scroll functionality again, some array creation and 
* manipulation, class adding and class removing, and conditional testing
*/
var aChildren = $("nav li").children(); // find the a children of the list items
var aArray = []; // create the empty aArray
for (var i = 0; i < aChildren.length; i++) {
    var aChild = aChildren[i];
    var ahref = $(aChild).attr('href');
    aArray.push(ahref);
} // this for loop fills the aArray with attribute href values

$(window).scroll(function () {
    var windowPos = $(window).scrollTop(); // get the offset of the window from the top of page
    var windowHeight = $(window).height(); // get the height of the window
    var docHeight = $(document).height();
});

$(function () {
    $(document).on('click', 'a.page-scroll', function (event) {
        var $anchor = $(this);
        $('html, body').stop().animate({
            scrollTop: $($anchor.attr('href')).offset().top - 70
        }, 1000, 'easeInOutExpo');
        event.preventDefault();
    });
});