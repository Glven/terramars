$(document).ready(function () {
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
});