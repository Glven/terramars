$(document).ready(function () {
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
});