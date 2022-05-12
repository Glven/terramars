$(document).ready(function () {
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
});