$(document).ready(function () {
    var headerSearch = $('.header-nav__form');
    var searchIcon = $('.header-nav__searchIcon');

    $(window).scroll(function(e){
        e.preventDefault();
        if($(window).scrollTop() > $('section').height() / 3){
            $('.header-fixed').addClass('header-fixed_active');
        }
        else{
            $('.header-fixed').removeClass('header-fixed_active');
        }
    });
    searchIcon.click(function(e){
        e.preventDefault();
        headerSearch.addClass('header-nav__form_active');
        $(this).addClass('header-nav__search_inactive');
    });
    $('body').keydown(function(e){
        if (e.which == 27){
            headerSearch.removeClass('header-nav__form_active');
            searchIcon.removeClass('header-nav__search_inactive');
        }
    });
    $(document).mouseup(function(e){
        e.preventDefault();
        if(headerSearch.has(e.target).length == 0){
            headerSearch.removeClass('header-nav__form_active');
            $('.header-nav__searchIcon').css({'display':'flex'});
            searchIcon.removeClass('header-nav__search_inactive');
        }
    });
});