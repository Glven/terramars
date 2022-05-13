$(document).ready(function () {
   var searchLine = $('.header-search__form');
   var searchIcon = $('.header-search__icon');
   var profileIcon = $('.header-profile__icon');
   var dropMenu = $('.header-drop');
   var profile = $('.header-profile');
   var containers = $('.header, .footer, .section');
   var sections = $('.section');
   var nav = $('.progressbar-nav');
   var headerHeight = $('.header').height() - 20;
   
   if($('section').hasClass('hero')){
      var modal = $('.modal');
      var modalContainer = $('.modal-container');
      var team = $('.team-wrapper').height();
      // параллакс эффект фона 
      $('.hero').mousemove(function (e) { 
         var layer = Array('.hero-layer-bg', '.hero-layer-1');
         layer.forEach(elem => {
            var speed = $(elem).attr("data-speed");
            $(elem).css({'transform':`translateX(${e.clientX * speed / 1000}px)`});
         });
      });
      
      // анимированное фиксированное меню
      
      // открытие модального окна
      
      $('.hero-buttons__send').on("click", function(e){
         e.preventDefault();
         modal.addClass('modal_active');
         containers.css({
            'filter':'blur(5px)',
            'transition':'all 0.3s'
         });
         $('body').css({'overflow-y' : 'hidden'});
      });
      $('.modal-container__close').click(function(e){
         e.preventDefault();
         modal.removeClass('modal_active');
         containers.css({'filter':'none'});
         $('body').css({'overflow-y' : 'scroll'});
      });
      modal.click(function(e){
         if(e.target == this && e.target != modalContainer){
            modal.removeClass('modal_active');
            containers.css({'filter':'none'});
            $('body').css({'overflow-y' : 'scroll'});
         }
      });
      // доп линия
      $('.after-team').css({'height': `${team * 2.5}px`}); 
      
      // настройка слайдера
      var swiper = new Swiper('.swiper', {
         // Optional parameters
         loop: true,
         
         pagination: {
            el: '.swiper-pagination',
            type: 'bullets',
         },
         
         navigation: {
            nextEl: '.swiper-button-next',
            prevEl: '.swiper-button-prev',
         },
      });
   }
   
   $(window).scroll(function(e){
      e.preventDefault();
      var cur_pos = $(this).scrollTop();
      var scroll = getCurrentScroll();
      if(scroll > $('section').height() / 3){
         $('.header').addClass('header_fixed');
      }
      else if(scroll <= $('.header').height()){
         $('.header').removeClass('header_fixed');
      }

      if(scroll > $('.header').height() * 2){
         $('.up').addClass('up_active');
      }
      else{
         $('.up').removeClass('up_active');
      }

      sections.each(function(){
         var top = $(this).offset().top - headerHeight,
         bottom = top + $(this).height();
         if(cur_pos >= top && cur_pos <= bottom){
            nav.find('a').removeClass('progressbar-nav__element_active');
            nav.find('a[href="#'+$(this).attr('id')+'"]').addClass('progressbar-nav__element_active');
         }
      });


      function getCurrentScroll() {
         return window.pageYOffset || document.documentElement.scrollTop;
      }
   });

   $('a[href^="#"]').on('click', function(e){
      e.preventDefault();
      var id = $(this).attr('href'),
          top = $(id).offset().top;
      $('html, body').animate({scrollTop: top - headerHeight}, 600);
    });
      
   $('.up').click(function(){
      $('html, body').animate({scrollTop: 0}, 500);
      return false;
      });
   
   // показ поиска
   searchIcon.click(function(e){
      e.preventDefault();
      searchLine.addClass('header-search__form_active');
      $(this).addClass('header-search__icon_inactive');
   });

   // скрытие поиска

   $('body').keydown(function(e){
      if(e.which == 27){
         if(searchLine.hasClass('header-search__form_active')){
            searchLine.removeClass('header-search__form_active');
            searchIcon.removeClass('header-search__icon_inactive');
         }
         if($('section').hasClass('hero') && modal.hasClass('modal_active')){
            modal.removeClass('modal_active');
            containers.css({'filter':'none'});
            $('body').css({'overflow-y' : 'scroll'});
         }
      }
   });

   // скрытие при нажатии за пределами поиска

   $(document).mouseup(function(e){
      e.preventDefault();
      if(searchLine.has(e.target).length == 0){
         searchLine.removeClass('header-search__form_active');
         searchIcon.removeClass('header-search__icon_inactive');
      }
   });

   // открытия выпадающего меню

   $(document).mouseover(function(e){
      e.preventDefault();
      if(profile.has(e.target).length == 1){
         profileIcon.addClass('header-profile__icon_active');
         dropMenu.addClass('header-drop_active');
      }
      else{
         profileIcon.removeClass('header-profile__icon_active');
         dropMenu.removeClass('header-drop_active');
      }
   });

   // открытие скрытого меню для телефонов

   $('.header-hiddenmenu__btn').click(function(e){
      e.preventDefault();
      $(this).toggleClass('header-hiddenmenu__btn_active');
      $('.hiddenmenu').toggleClass('hiddenmenu_active');
      containers.toggleClass('containers_activeHidden');
      if($('.up').hasClass('up_active') && $('.header-hiddenmenu__btn').hasClass('header-hiddenmenu__btn_active')){
         $('.up').removeClass('up_active');
      }
   });
  
  if($('section').hasClass('news')){
     // функции для страницы с новостями
      var news = $('.news-card p');
      var readmore = $('.news-card .readmore')
      news.each(function(index){
         if($(news[index]).height()>=100){
            $(readmore[index]).addClass('readmore_active');
         }
      });
      readmore.each(function(index){
         $(readmore[index]).click(function(){
            if($(this).text() == "Читать далее"){
                  $(news[index]).css({'max-height':'none'});
                  $(this).text("Свернуть");
            }
            else{
               $(news[index]).css({'max-height':'100px'});
               $(this).text("Читать далее");
            }
         });
      });
  }

  if($('section').hasClass('reg')){
      $('input').on('input', function(){
         $('#fullname').val($('#lastname').val()+' '+$('#name').val()+ ' ' + $('#secondname').val());
         $('#dateValue').val($('#date').val());
         if($('#male').is(':checked')){
            $('#sexValue').val('Мужской');
         }
         else if($('#female').is(':checked')){
            $('#sexValue').val('Женский');
         }
         $('#mail').val($('#email').val());
         $('#nickname').val($('#login').val());
         $('#phoneValue').val($('#phone').val());
         $('#passwordValue').val($('#password').val());
         console.log($('#fullname').val());
      });
  }

  if($('section').hasClass('calculate')){
      $('.calculate-total__value').val(10*10*3);

      $('.calculate-ranger__width').on('input', function(){
         $('#calculate-ranger__width').val($(this).val());
      });
      $('#calculate-ranger__width').on('input', function(){
         if(isNaN($(this).val())){
            alert("Вы можете ввести только число");
            $(this).val($('.calculate-ranger__width').attr('min'));
         }
         if(!$(this).val()){
            $(this).val($('.calculate-ranger__width').attr('min'));
         }
         $('.calculate-ranger__width').val($(this).val());
      });
      $('.calculate-ranger__height').on('input', function(){
         $('#calculate-ranger__height').val($(this).val());
      });
      $('#calculate-ranger__height').on('input', function(){
         if(isNaN($(this).val())){
            alert("Вы можете ввести только число");
            $(this).val($('.calculate-ranger__height').attr('min'));
         }
         if(!$(this).val()){
            $(this).val($('.calculate-ranger__width').attr('min'));
         }
         $('.calculate-ranger__height').val($(this).val());
      });

      $('input').on('input', function(){
         var square = 1;
         var values = $('.calculate-ranger__value');
         var result = 1;
         var soil = 15, meter = 3, trees = 12, water=250, electro = 125000 ,house = 500000, air = 250000, slave = 1000000;
         values.each(function(){
            square *= parseInt($(this).val());
         });
         result = square * meter;
         square /= 1000;
         $('.calculate-square__value').val(square);

         if($('#soil').is(':checked')){
            $('.soil').val('Есть');
            result += (soil * square);
         }
         else{
            $('.soil').val('Нет');
         }

         if($('#trees').is(':checked')){
            $('.trees').val('Есть');
            result += (trees * square);
         }
         else{
            $('.trees').val('Нет');
         }

         if($('#water').is(':checked')){
            $('.water').val('Есть');
            result += (water * square);
         }
         else{
            $('.water').val('Нет');
         }

         if($('#electro').is(':checked')){
            $('.electro').val('Есть');
            result += electro;
         }
         else{
            $('.electro').val('Нет');
         }

         if($('#house').is(':checked')){
            $('.house').val('Есть');
            result += house;
         }
         else{
            $('.house').val('Нет');
         }

         if($('#air').is(':checked')){
            $('.air').val('Есть');
            result += air;
         }
         else{
            $('.air').val('Нет');
         }

         if($('#slave').is(':checked')){
            $('.slave').val('Есть');
            result += slave;
         }
         else{
            $('.slave').val('Нет');
         }

         // итого
         $('.calculate-total__value').val(result.toFixed(1));
      });
  }
});
