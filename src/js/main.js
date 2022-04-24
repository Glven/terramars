$(document).ready(function () {

    var containers = $('.header, .footer, .section');
    var headerSearch = $('.header-search__form');

    $('.header-search__icon').click(function(e){
        e.preventDefault();
        headerSearch.addClass('header-search__form_active');
        $(this).css({'opacity' : '0'});
    });
    $('body').keydown(function(e){
        if(e.which == 27){
            headerSearch.removeClass('header-search__form_active');
            $('.header-search__icon').css({'opacity':'1'});
        }
    });
    $(document).mouseup(function(e){
        e.preventDefault();
        if(headerSearch.has(e.target).length==0){
            headerSearch.removeClass('header-search__form_active');
            $('.header-search__icon').css({'opacity':'1'});
        }
    });
    $(window).scroll(function(e){
        e.preventDefault();
        if($(window).scrollTop() > $('.section').height() / 2){
            $('.header-fixed').addClass('header-fixed_active');
        }
        else{
            $('.header-fixed').removeClass('header-fixed_active');
        }
      });
});