const loader = document.getElementById('loader');
const showLoader = () => loader.classList.remove('hidden');
const hideLoader = () => loader.classList.add('hidden');

const SubmitEnquiry = async () => {
    if (Validate()) {
        showLoader();
        try {
            var candidate_name = document.getElementById("candidate_name").value;
            var contact_number = document.getElementById("contact_number").value;
            var email_address = document.getElementById("email_address").value;
            var training_type = document.getElementById("training_type").value;
            var description = document.getElementById("description").value;
            var st = {
                "candidate_name": candidate_name,
                "mobile_number": contact_number,
                "email_address": email_address,
                "training_type": training_type,
                "description": description
            };
            const response = await fetch("/Lead/AddLeadSource", {
                method: "post",
                body: JSON.stringify(st),
                headers: {
                    "content-type": "application/json"
                }
            });
            const msg = await response.text();

            ClearData();
            document.getElementById("dvalert").removeAttribute("hidden");
            setTimeout(function () {
                document.getElementById("dvalert").setAttribute("hidden", "hidden");

            }, 4000);
        } catch (error) {
            console.error('Error fetching data:', error);
            console.log('Failed to load data.');

        } finally {
            // 2. Always hide the loader here, regardless of success or failure
            hideLoader();
        }
    }
}
const ClearData = () => {
    document.getElementById("candidate_name").value = "";
    document.getElementById("contact_number").value = "";
    document.getElementById("email_address").value = "";
    document.getElementById("training_type").value = "";
    document.getElementById("description").value = "";
}
// const FetchLeads=async()=>{
//       const response=await fetch("/Lead/GetLeads");
//       const leads=await response.json();

// }

function Validate() {
    var is_valid = true;
    var candidate_name = document.getElementById("candidate_name");
    var pattern = /^[a-zA-Z]+$/;
    if (!pattern.test(candidate_name.value.trim())) {
        candidate_name.classList.add("error-border");
        is_valid = false;
    }
    else {
        candidate_name.classList.remove("error-border");

    }
    var contact_number = document.getElementById("contact_number");
    var pattern = /^[a-zA-Z]+$/;
    if (!pattern.test(contact_number.value.trim())) {
        contact_number.classList.add("error-border");
        is_valid = false;
    }
    else {
        contact_number.classList.remove("error-border");

    }
    var email_address = document.getElementById("email_address");
    var emailspan = document.getElementById("sperror_email_address");
    var pattern = /^[a-zA-Z]+$/;
    if (!pattern.test(email_address.value.trim())) {
        email_address.classList.add("error-border");
       
        is_valid = false;
    }
    else {
        var emailpattern = /^[a-zA-Z]+[a-zA-Z0-9]*[@][a-zA-Z]+[.][a-zA-Z]+$/;
        if (!emailpattern.test(email_address.value.trim())) {
            email_address.classList.add("error-border");
            emailspan.innerHTML = "Invalid email address"
            is_valid = false;
        }
        else {
            alert("")
            email_address.classList.remove("error-border");
            emailspan.innerHTML = "";
        }
    }

    var training_type = document.getElementById("training_type")
    var pattern = /^[a-zA-Z]+$/;
    if (!pattern.test(training_type.value.trim())) {
        training_type.classList.add("error-border");
        is_valid = false;
    }
    else {
        training_type.classList.remove("error-border");
    }
    return is_valid;

    // var training_type=document.getElementById("training_type").value;
    // var description=document.getElementById("description").value;
}