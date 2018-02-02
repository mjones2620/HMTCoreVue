<template>
  <section id="forms" class="parallax">
    <div class="parallax-overlay">
        <div class="container">
            <div class="row">
                <div class="col-md-12">
                    <div id="aboutMe">
                        <div class="text-center">
                            <h2>Forms & Documents</h2>
                            <hr class="botm-line" />
                        </div>
                        <h4>New Clients</h4>
                        <p>
                            We have conveniently provided the intake paperwork online for you

                            to download, print and fill out before meeting for our first session.

                            Please complete all necessary documents and bring with you to

                            your first session along with photo ID and insurance card.

                            Alternatively, you may arrive 20 minutes early to your first session

                            and complete intake paperwork at my office. Couples, both of you will need to 

                            fill out an Intake Form (Adult).
                        </p>
                        <div class="row">   
                            <div class="col-xs-12">
                                <ul class="list-group">
                                    <li v-for="file in files" v-bind:key="file.name" class="list-group-item">
                                        <i class="fa fa-file-pdf-o"></i> <a :href="'docs/'+ file.name" download>{{file.name}}</a>
                                    </li>
                                </ul>
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
export default {
  name: 'documents',
  data() {
      return {
          files: []
      }
  },
  created() {
      var vm = this;
      this.$http.get('Files')
      .then(response => {
          vm.files = response.data;
      });
  }
}
</script>

