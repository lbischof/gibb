$(function() {
	$('#survey').on('submit', function() {
		if ($('input:radio:checked').length !== ($('input:radio').length/5)) { // We devide by five because there are five radio buttons for each question
			// Materialize.toast(message, displayLength, className, completeCallback);
  			Materialize.toast('Bitte alle Fragen beantworten!', 4000, 'rounded');
			return false; // Don't submit the form
		}
	});
	survey_url=window.location.hostname+window.location.pathname.replace('results', '');
	if (!window.localStorage.getItem('garlic:'+survey_url+'>form>input.q[0][value]')) //Check if the answers are in localstorage
		$('.showAnswers').css("visibility", "hidden"); 
});