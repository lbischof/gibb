$(function() {
	$('#survey').on('submit', function() {
		if ($('input:radio:checked').length !== ($('input:radio').length/5)) { // We devide by five because there are five radio buttons for each question
			// Materialize.toast(message, displayLength, className, completeCallback);
  			Materialize.toast('Bitte alle Fragen beantworten!', 4000, 'rounded');
			return false; // Don't submit the form
		}
	});

    $('#email').on('blur', function(){
        if ($(this).val())
            $(this).next().addClass('active');
    });

    $("input:disabled").closest("div").click(function () {
    	Materialize.toast('Sie haben die Umfrage schon beantwortet.', 6000, 'rounded');
    });
});
