$(document).ready(function () {
    var headerSearch = $('.header-nav__form');
    var profileIcon = $('.header-profile__icon');
    var headerProfile = $('.header-profile');
    var headerMenu = $('.header-profile__menu');
    var searchIcon = $('.header-nav__searchIcon');
    var containers = $('header, footer, section');

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
            $('.modal').removeClass('modal_active');
            containers.css({'filter':'none'});
        }
    });
    $(document).mouseup(function(e){
        e.preventDefault();
        if(headerSearch.has(e.target).length == 0){
            headerSearch.removeClass('header-nav__form_active');
            searchIcon.removeClass('header-nav__search_inactive');
        }
    });
    $(document).mouseover(function(e){
        e.preventDefault();
        if(headerProfile.has(e.target).length==1){
            headerMenu.addClass('header-profile__menu_active');
            profileIcon.addClass('header-profile__icon_active');
        }
        else{
            headerMenu.removeClass('header-profile__menu_active');
            $('.header-profile__wrap').removeClass('header-profile__wrap_active');
            profileIcon.removeClass('header-profile__icon_active');
        }
    });
    profileIcon.mouseover(function(e){
        e.preventDefault();
        headerMenu.addClass('header-profile__menu_active');
        if(e.target == this){
            $('.header-profile__wrap').addClass('header-profile__wrap_active');
        }
    });
    $('.menu-btn').click(function(e){
        e.preventDefault();
        $(this).toggleClass('menu-btn_active');
        $('.menu').toggleClass('menu_active');
    });
    $('.main-buttons__send').click(function(e){
        e.preventDefault();
        $('.modal').addClass('modal_active');
        containers.css({
            'filter':'blur(5px)',
            'transition':'all 0.3s'
        });
    });
    $('.modal-container__close').click(function(e){
        e.preventDefault();
        $('.modal').removeClass('modal_active');
        containers.css({'filter':'none'});
    });
    $('.modal').mouseup(function(e){
        e.preventDefault();
        if(e.target == this && e.target != $('.modal-container')){
            $('.modal').removeClass('modal_active');
            containers.css({'filter':'none'});
        }
    });
});