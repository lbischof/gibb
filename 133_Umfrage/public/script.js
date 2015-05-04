$(function() {
	$('#survey').on('submit', function() {
		if ($('input:radio:checked').length !== ($('input:radio').length/5)) { 
			// Materialize.toast(message, displayLength, className, completeCallback);
  			Materialize.toast('Bitte alle Fragen beantworten!', 4000, 'rounded') // 4000 is the duration of the toast
			return false;
		}
	});
});