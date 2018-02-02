<template>
<section id="appointments" class="parallax">
    <div class="parallax-overlay">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div id="aboutMe">
                        <div class="section-content text-center">
                            <h2>Book an Appointment</h2>
                            <hr class="botm-line" />
                        </div>
                        <div class="contact-section">
                            <div class="row">
                                <div class="col-md-8">
                                    <p>Use the form below to request an appointment. Correspondance will be handled and transmitted securely through e-mail.</p>
                                    <div class="clearfix"></div>
                                    <br />
                                    <div class="form-group">
                                        <label for="exampleInputUsername">Your Name</label>
                                        <input v-validate="{ rules: { required: true } }"
                                               type="text"
                                               class="form-control"
                                               placeholder=" Enter Name"
                                               name="Name"
                                               v-model="request.name">
                                        <span v-show="errors.has('Name')" class="small text-danger">{{ errors.first('Name') }}</span>
                                    </div>
                                    <div class="form-group">
                                        <label for="exampleInputEmail">Email Address</label>
                                        <p class="control has-icon has-icon-right">
                                            <input v-validate="{ rules: { required: true, email: true } }"
                                                   class="form-control"
                                                   name="E-mail"
                                                   type="email"
                                                   placeholder=" Enter Email id"
                                                   v-model="request.email">
                                            <span v-show="errors.has('E-mail')" class="small text-danger">{{ errors.first('E-mail') }}</span>
                                        </p>
                                    </div>
                                    <div class="form-group">
                                        <label for="telephone">Mobile No.</label>
                                        <masked-input v-validate="{ rules: { required: true } }"
                                               mask="\+\1 (111) 111-1111"
                                               type="tel"
                                               class="form-control"
                                               name="Phone Number"
                                               placeholder=" Enter 10-digit mobile no."
                                               v-model="request.phoneNumber" />
                                        <span v-show="errors.has('Phone Number')" class="small text-danger">{{ errors.first('Phone Number') }}</span>
                                    </div>
                                    <div class="form-group">
                                        <label for="telephone">Desired Date</label>
                                        <input v-validate="{ rules: { required: true } }"
                                               placeholder="dd/mm/yyyy"
                                               id="date"
                                               type="text"
                                               class="form-control date"
                                               name="Desired Date"
                                               v-model="request.date" />
                                        <span v-show="errors.has('Desired Date')" class="small text-danger">{{ errors.first('Desired Date') }}</span>
                                    </div>
                                    <div class="form-group">
                                        <label for="description"> Message</label>
                                        <textarea v-validate="{ rules: { required: true } }"
                                                  v-model="request.message"
                                                  v-on:input="preventLength('message', 8000)"
                                                  rows="6"
                                                  class="form-control"
                                                  name="Message"
                                                  placeholder="Enter Your Message">
                                    </textarea>
                                        <span v-show="errors.has('Message')" class="small text-danger">{{ errors.first('Message') }}</span>
                                        <small v-if="(request.message) && request.message.length > 0" class="text-muted">{{8000 - request.message.length}} Characters remaining..</small>
                                    </div>
                                    <div>
                                        <button type="button" v-bind:disabled="errors.any() 
                                                            || request.name.length == 0" 
                                                            class="btn btn-primary submit" 
                                                            v-on:click="sendRequest">
                                                                <i class="fa fa-check" aria-hidden="true"></i>  Send</button>
                                    </div>
                                </div>
                                <div class="col-md-4">
                                    <div class="contact-icon-container hidden-md hidden-sm hidden-xs">
                                        <span aria-hidden="true" class="fa fa-calendar-check-o"></span>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
</section>
</template>

<script>
import bootbox from 'bootbox'
import maskedInput from 'vue-masked-input'
import flatpickr from "flatpickr"

export default {
        name: 'appointments',
        data() {
            return {
                request: {
                    name: '',
                    email: '',
                    phoneNumber: '',
                    message: '',
                    date: ''
                },
                isDisabled: true
            }
        },
        mounted(){
            flatpickr('#date');
        },
        components:{
          maskedInput  
        },
        methods: {
            preventLength(prop, max){
                if(this.request[prop].length > max){
                    this.request[prop] = this.request[prop].substring(0, 8000);
                }
            },
            sendRequest() {
                var request = {
                    Name: this.request.name,
                    EmailAddress: this.request.email,
                    PhoneNumber: this.request.phoneNumber,
                    Message: this.request.message,
                    Date: this.request.date
                }

                return this.$http.post("Appointments", request)
                    .then(response => {
                        bootbox.alert("Your request has been sent. You will contacted be as soon as it is recieved.");
                    },
                    response => {
                         bootbox.alert("An issue has occured, please refresh your browser");
                     })
            }
        }
}
</script>
