const numberInput = document.getElementById('SINInput');

numberInput.addEventListener('input', (event) => {
  const inputValue = event.target.value;
  const onlyNumbers = inputValue.replace(/\D/g, '');

  if (onlyNumbers !== inputValue) {
    event.target.value = onlyNumbers;
  }
});
$("input:checkbox").on('click', function() {
    var $box = $(this);
    if ($box.is(":checked")) {
      var group = "input:checkbox[name='" + $box.attr("name") + "']";
      $(group).prop("checked", false);
      $box.prop("checked", true);
    } else {
      $box.prop("checked", false);
    }
  });
const phoneInput = document.getElementById('phoneInput');

phoneInput.addEventListener('input', (event) => {
  const input = event.target.value.replace(/\D/g, '');
  const match = input.match(/^(\d{3})(\d{3})(\d{4})$/);

  if (match) {
    event.target.value = `(${match[1]}) ${match[2]}-${match[3]}`;
  }
});


const usCitizenNo = document.getElementById('usCitizenNo');
const workInUsQuestion = document.getElementById('workInUsQuestion');
usCitizenNo.addEventListener('change', () => {
  if (usCitizenNo.checked) {
    workInUsQuestion.style.display = 'block';
  }
});
const workedForEmployerYes = document.getElementById('workedForEmployerYes');
const workDates = document.getElementById('workDates');

const felonyYes = document.getElementById('felonyYes');
const felonyExplanationDiv = document.getElementById('felonyExplanationDiv');

workedForEmployerYes.addEventListener('change', () => {
  if (workedForEmployerYes.checked) {
    workDates.style.display = 'block';
  } else {
    workDates.style.display = 'none';
  }
});

felonyYes.addEventListener('change', () => {
  if (felonyYes.checked) {
    felonyExplanationDiv.style.display = 'block';
  } else {
    felonyExplanationDiv.style.display = 'none';
  }
});

